using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTD.Common;
using OurWeb.Controls;

namespace OurWeb
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int control = Utility.GetIntParameter("ctl");
            
                Utility.LoadPageContent(this.PlaceHolder1, ControlSettings.GetControlFileName((ControlSettings.ControlName)control, Global.MainControlsPath));
        }
    }
}