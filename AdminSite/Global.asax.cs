﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace AdminSite
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
            Login = 0,
            Welcome = 1
        }

        public const string ControlsPath = "~/Controls/";
        public const string MainPageName = "Admin.aspx";
        public const string ErrorLogin = "*Error - Invalid User/Password";
        //public const string stControlsPath = "~/st/Controls/";
        //public const string teControlsPath = "~/te/Controls/";
        //public const string AdmissionControlsPath = "~/Admission/Controls/";
        //public const string AdminPath = "Admin/";
        //public const string BioImagesPath = "~/bioimages/";
        //public const string BioPrintableFilePath = "~/biofiles/";
        //public const string ArticlesPath = "~/articlefiles/";
        //public const string ClientDocsPath = "~/clientdocs/";
        //public const string PageHeaderImagePath = "~/pageimages/";
        //public const string PhotoPath = "~/photos/";
        //public const string GalleryPath = "~/gallery/";
        //public const string HeaderImagePath = "~/headerimages/";
        //public const string DocRepositoryPath = "~/docrepository/";
        //public const string ClientLogoPath = "~/upload/ClientLogo/";
        //public const string ClientResumePath = "~/upload/Resume/";
        //public const string EmployeePicturePath = "~/upload/EmployeePictures/";
        //public const string EventPhotos = "~/upload/EventPhotos/";
        //public const string JqueryImages = "~/upload/jqueryimages/";
        //public const string StudentPhotos = "~/upload/StudentPhotos/";
        //public const string TeacherPhotos = "~/upload/TeacherPhotos/";
        //public const string TeacherFiles = "~/Upload/TeacherFiles/";
        //public const string AdmissionForms = "~/Upload/AdmissionForms/";

        public static string GetPageLink(Global.PageLink PageType)
        {
            string page = "Admin.aspx?";
            string qry = "";
            switch (PageType)
            {
                case PageLink.Login:
                    qry = "ctl=0";
                    break;
                case PageLink.Welcome:
                    qry = "ctl=1";
                    break;
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
