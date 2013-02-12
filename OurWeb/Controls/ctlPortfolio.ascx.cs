using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OurWeb.Dao;

namespace OurWeb.Controls
{
    public partial class ctlPortfolio : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void BindAllPortfolio()
        {
            PortfolioController portfolioController = new PortfolioController();
            
        }
    }
}