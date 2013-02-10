using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminSite.Dao;
using System.Collections.Specialized;
using System.Web.Services;

namespace AdminSite.Controls
{
    public partial class ctlLogin : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Common.Common.showSideBar = false;
            divStatusError.Visible = false;
            if (!IsPostBack)
            {
                ClearForm();
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            //As user and password is validated on client side.. So no need to check empty values here..
            LoginController loginController = new LoginController();
            Model.Login login = new Model.Login("userName", user);

            if (login != null)
            {
                if (login.Password.Equals(password, StringComparison.InvariantCultureIgnoreCase))
                {
                    Session["loginUser"] = user;
                    Session["Name"] = login.FName + " " + login.LName;
                    Session["loginId"] = login.LoginId;
                    Common.Common.showSideBar = true;
                    ClearForm();
                    Response.Redirect(Global.GetPageLink(Global.PageLink.Welcome));
                }
                else
                {
                    divStatusError.Visible = true;
                    lblError.Text = Global.ErrorLogin;
                }
            }
        }

        public void ClearForm()
        {
            txtUser.Text = "";
            txtPassword.Text = "";
            lblError.Text = "";
        }
    }
}