using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Dao;
using OurWeb.Model;
using System.Collections;
using System.Data;
using TTD.Common;

namespace OurWeb.Admin.Controls
{
    public partial class ctlAddProject : System.Web.UI.UserControl
    {
        int projectId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            divStatusError.Visible = false;
            divStatusSuccess.Visible = false;
            projectId = Utility.GetIntParameter("id");
            if (projectId > 0)
            {
                LoadProject(projectId);
            }
            else if (!IsPostBack)
            {
                BindClients();
            }
        }
        public void BindClients()
        {

            ClientController clientController = new ClientController();

            DataTable dt = new DataTable();
            DataColumn id = new DataColumn("ClientId", typeof(Int32));
            dt.Columns.Add(id);
            DataColumn name = new DataColumn("ClientName", typeof(string));
            dt.Columns.Add(name);
            DataRow row = null;

            ArrayList l = new ArrayList();
            foreach (Client client in clientController.FetchAll())
            {
                row = dt.NewRow();
                row["ClientId"] = client.ClientId;
                row["ClientName"] = client.ClientName;
                dt.Rows.Add(row);
            }
            ddlClients.DataSource = dt;
            ddlClients.DataTextField = dt.Columns[1].ToString();
            ddlClients.DataValueField = dt.Columns[0].ToString();
            ddlClients.DataBind();
        }

        protected void BindClients(object sender, EventArgs e)
        {
            BindClients();
        }

        protected void btnAddProject_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                if (projectId > 0)
                {
                    Project project = new Project(projectId);
                    project.IsNew = false;

                    project.ProjectName = txtProjectName.Text;
                    project.ProjectDescription = txtProjectDescription.Text;
                    project.ProjectAssignedResource = txtAssignedResourceName.Text;
                    project.ProjectURL = txtProjectURL.Text;
                    project.ClientId = Int32.Parse(ddlClients.DataValueField);
                    project.ProjectStartDate = cpStartDate.SelectedDate;
                    project.ProjectEndDate = cpEndDate.SelectedDate;

                    try
                    {
                        project.Save();
                        divStatusError.Visible = false;
                        divStatusSuccess.Visible = true;
                        lblStatusSuccess.Text = AdminSite.Global.SuccessLabelStatus;
                        //lblStatusSuccess.ForeColor = System.Drawing.Color.Green;
                    }
                    catch (Exception ex)
                    {
                        divStatusSuccess.Visible = false;
                        divStatusError.Visible = true;
                        labelStatusError.Text = AdminSite.Global.ErrorLabelStatus + ex.ToString();
                        //labelStatusError.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    try
                    {
                        Save();
                    }
                    catch (Exception ex)
                    {
                        divStatusSuccess.Visible = false;
                        divStatusError.Visible = true;
                        labelStatusError.Text = AdminSite.Global.ErrorLabelStatus + ex.ToString();
                    }
                }
            }
        }

        public void ClearForm()
        {
            ddlClients.Dispose();
            BindClients();
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtAssignedResourceName.Text = "";
            txtProjectURL.Text = "";
            cpStartDate.SelectedDate = DateTime.Today;
            cpEndDate.SelectedDate = DateTime.Today;
        }

        public void LoadProject(int pProjectId)
        {
            Project project = new Project(pProjectId);
            txtProjectName.Text = project.ProjectName;
            txtProjectDescription.Text = project.ProjectDescription;
            txtAssignedResourceName.Text = project.ProjectAssignedResource;
            txtProjectURL.Text = project.ProjectURL;
            cpStartDate.SelectedDate = project.ProjectStartDate;
            cpEndDate.SelectedDate = project.ProjectEndDate;
            BindClients();
            ddlClients.SelectedValue = project.ClientId.ToString();
            ddlClients.Enabled = false;
            //BindClientsDDL (project.ClientId);
        }

        public void BindClientsDDL(int clientId)
        {
            Client client = new Client(clientId);

        }
        public void Save()
        {
            Project project = new Project(projectId);
            project.IsNew = true;

            project.ProjectName = txtProjectName.Text;
            project.ProjectDescription = txtProjectDescription.Text;
            project.ProjectAssignedResource = txtAssignedResourceName.Text;
            project.ProjectURL = txtProjectURL.Text;
            project.ClientId = Int32.Parse(ddlClients.SelectedValue);
            project.ProjectStartDate = cpStartDate.SelectedDate.Date;
            project.ProjectEndDate = cpEndDate.SelectedDate.Date;
            project.Save();

            //Now Save Picture As Well..
           
            divStatusError.Visible = false;
            divStatusSuccess.Visible = true;
            lblStatusSuccess.Text = AdminSite.Global.SuccessLabelStatus;
            //lblStatusSuccess.ForeColor = System.Drawing.Color.Green;
           
            ClearForm();
        }
    }
}