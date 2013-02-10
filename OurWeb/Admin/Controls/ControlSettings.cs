using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminSite.Controls
{
    public class ControlSettings
    {
        public enum ControlName : int
        {
            Login = 0,
            Welcome = 1,
            AddServices = 2,
            ManageServices = 3,
            AddNews = 4,
            Services = 5,
            News = 6,
            ManageNews = 7,
            Client = 8,
            AddClient = 9,
            ManageClient = 10,
            Project = 11,
            AddProject = 12,
            ManageProject = 13,
            ManageRequests = 14,
            UploadAdmissionForm = 15
        }

        public static string GetControlFileName(ControlName controlId, string folderPath)
        {
            string controlName = "";
            string ext = ".ascx";
            switch (controlId)
            {
                case ControlName.Welcome:
                    controlName = "ctlWelcome";
                    break;
                case ControlName.AddServices:
                    controlName = "ctlAddServices";
                    break;
                case ControlName.ManageServices:
                    controlName = "ctlManageServices";
                    break;
                case ControlName.AddNews:
                    controlName = "ctlAddNews";
                    break;
                case ControlName.Services:
                    controlName = "ctlServices";
                    break;
                case ControlName.News:
                    controlName = "ctlNews";
                    break;
                case ControlName.ManageNews:
                    controlName = "ctlManageNews";
                    break;
                case ControlName.Client:
                    controlName = "ctlClient";
                    break;
                case ControlName.AddClient:
                    controlName = "ctlAddClient";
                    break;
                case ControlName.ManageClient:
                    controlName = "ctlManageClient";
                    break;
                case ControlName.Project:
                    controlName = "ctlProject";
                    break;
                case ControlName.AddProject:
                    controlName = "ctlAddProject";
                    break;
                case ControlName.ManageProject:
                    controlName = "ctlManageProject";
                    break;
                //case ControlName.ManageRequests:
                //    controlName = "ctlManageRequests";
                //    break;
                //case ControlName.UploadAdmissionForm:
                //    controlName = "ctlUploadAdmissionForm";
                //    break;
                default:
                    controlName = "ctlLogin";
                    break;
            }
            controlName += ext;
            return (String.IsNullOrEmpty(folderPath) == false ? folderPath + controlName : controlName);
        }
    }
}