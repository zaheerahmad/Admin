using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OurWeb
{
    public class Global : System.Web.HttpApplication
    {
        public enum MessageType : int
        {
            Success = 1,
            Exception = 2
        }
        public enum PageLink : int
        {
            Home = 0,
            Portfolio = 1,
            Services = 2,
            Contact = 3,
            Clients = 4,
            //Services = 5,
            //News = 6,
            //ManageNews = 7,
            //Client = 8,
            //AddClient = 9,
            //ManageClient = 10,
            //Project = 11,
            //AddProject = 12,
            //ManageProject = 13,
            //Portfolio = 14,
            //AddPortfolio = 15,
            //ManagePortfolio = 16
        }

        public const string AdminPath = "Admin/";
        public const string MainControlsPath = "~/Controls/";

        public static string GetPageLink(Global.PageLink PageType)
        {
            string page = "Admin.aspx?";
            string qry = "";
            switch (PageType)
            {
                //case PageLink.Home:
                //    qry = "ctl=0";
                //    break;
                case PageLink.Portfolio:
                    qry = "ctl=1";
                    break;
                case PageLink.Services:
                    qry = "ctl=2";
                    break;
                case PageLink.Contact:
                    qry = "ctl=3";
                    break;
                case PageLink.Clients:
                    qry = "ctl=4";
                    break;
                //case PageLink.Services:
                //    qry = "ctl=5";
                //    break;
                //case PageLink.News:
                //    qry = "ctl=6";
                //    break;
                //case PageLink.ManageNews:
                //    qry = "ctl=7";
                //    break;
                //case PageLink.Client:
                //    qry = "ctl=8";
                //    break;
                //case PageLink.AddClient:
                //    qry = "ctl=9";
                //    break;
                //case PageLink.ManageClient:
                //    qry = "ctl=10";
                //    break;
                //case PageLink.Project:
                //    qry = "ctl=11";
                //    break;
                //case PageLink.AddProject:
                //    qry = "ctl=12";
                //    break;
                //case PageLink.ManageProject:
                //    qry = "ctl=13";
                //    break;
                //case PageLink.Portfolio:
                //    qry = "ctl=14";
                //    break;
                //case PageLink.AddPortfolio:
                //    qry = "ctl=15";
                //    break;
                //case PageLink.ManagePortfolio:
                //    qry = "ctl=16";
                //    break;
                default:
                    qry = "ctl=0";
                    break;
            }
            return page += qry;
        }

        public static void SetMessage(System.Web.UI.WebControls.Label label, MessageType type)
        {
            switch (type)
            {
                case MessageType.Success:
                    label.CssClass = "good";
                    label.Visible = true;
                    break;
                case MessageType.Exception:
                    label.CssClass = "bad";
                    label.Visible = true;
                    break;
            }

        }
        public static string GetImgPath(string path, string size)
        {
            return "CreateThumbnail.aspx?image=" + path.Remove(0, 1).Remove(0, 1) + "&size=" + size;
        }
        public static string GetImgRootPath(string path, string size)
        {
            return "~/CreateThumbnail.aspx?image=" + path + "&size=" + size;
        }

        //public static string GetHeaderImagePath(string imgName)
        //{
        //    //return Global.PageHeaderImagePath + imgName;
        //}
        public static void SecureClientPage()
        {
            HttpContext context = System.Web.HttpContext.Current;
            if (context.Session["ClientEmail"] != null)
            {
                //  if(context.Session["ClientEmail"].ToString() == "
            }
            else
            {
                context.Response.Redirect("ClientLogin.aspx");
            }
        }
        public static string GetLogedInClientEmail()
        {
            HttpContext context = System.Web.HttpContext.Current;
            if (context.Session["ClientEmail"] != null)
            {
                return context.Session["ClientEmail"].ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        public static void ClearMessage(System.Web.UI.WebControls.Label label)
        {
            label.Text = "";
            label.Visible = false;
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup

        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
