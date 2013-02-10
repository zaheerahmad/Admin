using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Model;

namespace OurWeb.Admin.Controls
{
    public partial class ctlManageProject : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindProject();
        }

        public int NewsPageIndex
        {
            get
            {

                object o = this.ViewState["_PageIndex"];
                if (o == null)
                    return 0;
                else
                    return (int)o;
            }

            set
            {
                this.ViewState["_PageIndex"] = value;
            }
        }

        void BindProject()
        {
            ProjectCollection projectCollection = new ProjectCollection();
            //coll.Where(DocCat.Columns.Active, 1);
            projectCollection.Load();
            grdProject.DataSource = projectCollection;
            grdProject.DataBind();
            //pnlMain.UpdateAfterCallBack = true;

        }

        protected void grdProject_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProject.PageIndex = e.NewPageIndex;
            BindProject();
        }

        protected void btnShowAddCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(AdminSite.Global.GetPageLink(AdminSite.Global.PageLink.AddNews));
        }

        void DeleteNews(int Id)
        {
            Project.Destroy(Id);
        }

        protected void rptProject_ItemCommand(object source, GridViewCommandEventArgs e)
        {
            string command = e.CommandName;
            if (command == "Del")
            {
                DeleteNews(int.Parse(e.CommandArgument.ToString()));
                grdProject.EditIndex = -1;
                BindProject();
            }
        }
    }
}