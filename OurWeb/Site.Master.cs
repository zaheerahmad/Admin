using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminSite.Common;
using AdminSite.Dao;


namespace OurWeb
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        public static bool showFrmAdministrator = false;
        public static bool showFrmContact = false;

        protected void Page_Load(object sender, EventArgs e)
        {
               
        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            //As user and password is validated on client side.. So no need to check empty values here..
            LoginController loginController = new LoginController();
            AdminSite.Model.Login login = new AdminSite.Model.Login("userName", user);

            if (login != null)
            {
                if (login.Password.Equals(password, StringComparison.InvariantCultureIgnoreCase))
                {
                    Session["loginUser"] = user;
                    Session["Name"] = login.FName + " " + login.LName;
                    Session["loginId"] = login.LoginId;
                    Common.showSideBar = true;
                    //ClearForm();
                    Response.Redirect(Global.AdminPath + AdminSite.Global.GetPageLink(AdminSite.Global.PageLink.Welcome));
                }
                else
                {
                    divStatusError.Visible = true;
                    lblError.Text = AdminSite.Global.ErrorLogin;
                }
            }
        }
    }
}
