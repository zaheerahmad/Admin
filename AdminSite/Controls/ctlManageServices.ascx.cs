using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminSite.Model;

namespace AdminSite.Controls
{
    public partial class ctlManageServices : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindServices();
        }

        public int ServicesPageIndex
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
        
        void BindServices()
        {
            ServiceCollection serviceCollection = new ServiceCollection();
            //coll.Where(DocCat.Columns.Active, 1);
            serviceCollection.Load();
            grdServices.DataSource = serviceCollection;
            grdServices.DataBind();
            //pnlMain.UpdateAfterCallBack = true;

        }
        
        protected void grdServices_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdServices.PageIndex = e.NewPageIndex;
            BindServices();
        }
        
        protected void btnShowAddCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Global.GetPageLink(Global.PageLink.AddServices));
        }

        void DeleteEvents(int Id)
        {
            Service.Destroy(Id);
        }

        protected void rptServices_ItemCommand(object source, GridViewCommandEventArgs e)
        {
            string command = e.CommandName;
            if (command == "Del")
            {
                DeleteEvents(int.Parse(e.CommandArgument.ToString()));
                grdServices.EditIndex = -1;
                BindServices();
            }
        }
    }
}