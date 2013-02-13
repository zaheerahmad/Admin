using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Model;
using OurWeb.Dao;
using System.Data;
using System.Collections;
using System.IO;
using TTD.Common;

namespace OurWeb.Admin.Controls
{
    public partial class ctlAddPortfolio : System.Web.UI.UserControl
    {
        int portfolioId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            divStatusError.Visible = false;
            divStatusSuccess.Visible = false;
            portfolioId = Utility.GetIntParameter("id");
            if (portfolioId > 0)
            {
                LoadPortfolio(portfolioId);
            }
            else
            {
                BindToolsAndTechniques();
            }
        }

        public void BindToolsAndTechniques()
        {
            ToolsAndTechniqueController toolsController = new ToolsAndTechniqueController();
            DataTable dt = new DataTable();
            DataColumn id = new DataColumn("toolsId", typeof(Int32));
            dt.Columns.Add(id);
            DataColumn name = new DataColumn("toolsName", typeof(string));
            dt.Columns.Add(name);
            DataRow row = null;

            ArrayList l = new ArrayList();
            foreach (ToolsAndTechnique tools in toolsController.FetchAll())
            {
                row = dt.NewRow();
                row["toolsId"] = tools.TatId;
                row["toolsName"] = tools.TatName;
                dt.Rows.Add(row);
            }
            chkBoxList1.DataSource = dt;
            chkBoxList1.DataTextField = dt.Columns[1].ToString();
            chkBoxList1.DataValueField = dt.Columns[0].ToString();
            chkBoxList1.DataBind();
        }

        string UploadPrintableFile(Portfolio portfolio)
        {
            string NewFileName = portfolio.PortfolioId + "-" + Path.GetFileName(fuPortfolioImage.PostedFile.FileName);
            string FileNameWithoutExt = portfolio.PortfolioId + "-" + Path.GetFileNameWithoutExtension(fuPortfolioImage.PostedFile.FileName);
            string error;
            if (fuPortfolioImage.PostedFile.FileName == null || fuPortfolioImage.PostedFile.FileName.Equals("") && portfolioId == 0)
            {
                portfolio = new Portfolio(Portfolio.Columns.PortfolioId, portfolio.PortfolioId);
                portfolio.IsNew = false;
                portfolio.PortfolioImage = "NoImage.jpg";
                portfolio.Save(Guid.NewGuid());
                return string.Empty;
            }
            if (fuPortfolioImage.PostedFile.ContentLength > 1)
            {
                Utility.DeleteFile(AdminSite.Global.PortFolio + portfolio.PortfolioImage);
                if (Utility.UploadFile(fuPortfolioImage, FileNameWithoutExt, AdminSite.Global.PortFolio, out error))
                {
                    portfolio = new Portfolio(Portfolio.Columns.PortfolioId, portfolio.PortfolioId);
                    portfolio.IsNew = false;
                    portfolio.PortfolioImage = NewFileName;
                    portfolio.Save(Guid.NewGuid());
                }
                else
                {
                    Client.Destroy(portfolio.PortfolioId);
                    return error.ToString();
                }
            }
            return String.Empty;
        } // Upload file ends here 

        public void ClearForm()
        {
            txtProjectName.Text = "";
            txtProjectDescription.Text = "";
            txtProjectURL.Text = "";
            chkBoxList1.Dispose();
            BindToolsAndTechniques();
        }

        public void LoadPortfolio(int pPortfolioId)
        {
            Portfolio portfolio = new Portfolio(pPortfolioId);
            txtProjectName.Text = portfolio.ProjectName;
            txtProjectDescription.Text = portfolio.ProjectDescription;
            String toolsAndTechnique = portfolio.ToolsAndTechniques;
            String[] toolsAndTechniquesArr = toolsAndTechnique.Split(new Char[] {','}, StringSplitOptions.RemoveEmptyEntries);
            //Int32[] tools = toolsAndTechniquesArr.ToArray<Int32>();
            //for (int i = 0; i < toolsAndTechnique.Length; i++)
            //{
            //    tools[i] = Int32.Parse(toolsAndTechniquesArr[i]);
            //}
            BindToolsAndTechniques();
            ArrayList l = new ArrayList();
            for (int i = 0; i < toolsAndTechniquesArr.Length; i++)
            {
                l.Add(Int32.Parse(toolsAndTechniquesArr[i]));
            }
            foreach (ListItem item in chkBoxList1.Items)
            {
                if(l.Contains(Int32.Parse(item.Value)))
                {
                    item.Selected = true;
                }
            }
            txtProjectURL.Text = portfolio.ProjectURL;
        }

        public void Save()
        {
            Portfolio portfolio = new Portfolio();
            portfolio.IsNew = true;
            portfolio.ProjectName = txtProjectName.Text;
            portfolio.ProjectDescription = txtProjectDescription.Text;
            portfolio.ProjectURL = txtProjectURL.Text;
            String toolsAndTechniques = String.Empty;
            foreach (ListItem item in chkBoxList1.Items)
            {
                if (item.Selected)
                {
                    toolsAndTechniques = String.Concat(toolsAndTechniques,item.Value, ",");
                }
            }
            portfolio.ToolsAndTechniques = toolsAndTechniques;
            portfolio.Save();

            //Now Save Picture As Well..
            string result = UploadPrintableFile(portfolio);
            if (result.Equals(""))
            {
                divStatusError.Visible = false;
                divStatusSuccess.Visible = true;
                lblStatusSuccess.Text = AdminSite.Global.SuccessLabelStatus;
                //lblStatusSuccess.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                divStatusSuccess.Visible = false;
                divStatusError.Visible = true;
                labelStatusError.Text = AdminSite.Global.ErrorLabelStatus + result;
                //labelStatusError.ForeColor = System.Drawing.Color.Red;
            }
            ClearForm();
        }

        protected void btnAddProject_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                if (portfolioId > 0)
                {
                    Portfolio portfolio = new Portfolio(portfolioId);
                    portfolio.IsNew = false;
                    portfolio.ProjectName = txtProjectName.Text;
                    portfolio.ProjectDescription = txtProjectDescription.Text;
                    portfolio.ProjectURL = txtProjectURL.Text;
                    String toolsAndTechniques = String.Empty;
                    foreach (ListItem item in chkBoxList1.Items)
                    {
                        if (item.Selected)
                        {
                            toolsAndTechniques = String.Concat(toolsAndTechniques,item.Value, ",");
                        }
                    }
                    portfolio.ToolsAndTechniques = toolsAndTechniques;

                    try
                    {
                        portfolio.Save();
                        UploadPrintableFile(portfolio);
                        divStatusError.Visible = false;
                        divStatusSuccess.Visible = true;
                        lblStatusSuccess.Text = AdminSite.Global.UpdatedLabelStatus;
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
    }
}