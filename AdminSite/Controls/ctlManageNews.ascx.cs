using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminSite.Model;

namespace AdminSite.Controls
{
    public partial class ctlManageNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindNews();
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

        void BindNews()
        {
            NewsCollection newsCollection = new NewsCollection();
            //coll.Where(DocCat.Columns.Active, 1);
            newsCollection.Load();
            grdNews.DataSource = newsCollection;
            grdNews.DataBind();
            //pnlMain.UpdateAfterCallBack = true;

        }

        protected void grdNews_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdNews.PageIndex = e.NewPageIndex;
            BindNews();
        }

        protected void btnShowAddCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Global.GetPageLink(Global.PageLink.AddNews));
        }

        void DeleteNews(int Id)
        {
            News.Destroy(Id);
        }

        protected void rptNews_ItemCommand(object source, GridViewCommandEventArgs e)
        {
            string command = e.CommandName;
            if (command == "Del")
            {
                DeleteNews(int.Parse(e.CommandArgument.ToString()));
                grdNews.EditIndex = -1;
                BindNews();
            }
        }
    }
}