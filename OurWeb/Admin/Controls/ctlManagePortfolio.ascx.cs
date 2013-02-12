using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Model;

namespace OurWeb.Admin.Controls
{
    public partial class ctlManagePortfolio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindPortfolio();
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

        void BindPortfolio()
        {
            PortfolioCollection portfolioCollection = new PortfolioCollection();
            //coll.Where(DocCat.Columns.Active, 1);
            portfolioCollection.Load();
            grdProject.DataSource = portfolioCollection;
            grdProject.DataBind();
            //pnlMain.UpdateAfterCallBack = true;

        }

        protected void grdProject_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProject.PageIndex = e.NewPageIndex;
            BindPortfolio();
        }

        protected void btnShowAddCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(AdminSite.Global.GetPageLink(AdminSite.Global.PageLink.Portfolio));
        }

        void DeletePortfolio(int Id)
        {
            Portfolio.Destroy(Id);
        }

        protected void rptProject_ItemCommand(object source, GridViewCommandEventArgs e)
        {
            string command = e.CommandName;
            if (command == "Del")
            {
                DeletePortfolio(int.Parse(e.CommandArgument.ToString()));
                grdProject.EditIndex = -1;
                BindPortfolio();
            }
        }
    }
}