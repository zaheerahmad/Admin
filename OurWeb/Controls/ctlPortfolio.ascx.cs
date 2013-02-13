using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Dao;
using OurWeb.Model;

namespace OurWeb.Controls
{
    public partial class ctlPortfolio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindAllPortfolio();
        }

        public void BindAllPortfolio()
        {
            PortfolioCollection col = new PortfolioController().FetchAll();
            //rptEvent.DataSource = col;
            //rptEvent.DataBind();
            
        }
        public string GetImgPath(string path, string size)
        {
            return "CreateThumbnail.aspx?image=" + path.Remove(0, 1).Remove(0, 1) + "&size=" + size;
        }
    }
}