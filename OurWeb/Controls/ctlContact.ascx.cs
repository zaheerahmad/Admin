﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OurWeb.Controls
{
    public partial class ctlContact : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SiteMaster.showFrmAdministrator = false;
            SiteMaster.showFrmContact = true;
        }


    }
}