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
            ManageEvents = 2,
            Addjquery = 3,
            ManageJquery = 4,
            AddDegree = 5,
            ManageDegree = 6,
            AddSubject = 7,
            ManageSubjects = 8,
            AddStudent = 9,
            ManageStudent = 10,
            AddTeacher = 11,
            ManageTeacher = 12,
            TimeTable = 13,
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
                //case ControlName.ManageEvents:
                //    controlName = "ctlManageEvents";
                //    break;
                //case ControlName.Addjquery:
                //    controlName = "AddJquery";
                //    break;
                //case ControlName.ManageJquery:
                //    controlName = "ctlManageJquery";
                //    break;
                //case ControlName.AddDegree:
                //    controlName = "ctlAddDegree";
                //    break;
                //case ControlName.ManageDegree:
                //    controlName = "ctlManageDegree";
                //    break;
                //case ControlName.AddSubject:
                //    controlName = "ctlAddSubject";
                //    break;
                //case ControlName.ManageSubjects:
                //    controlName = "ctlManageSubject";
                //    break;
                //case ControlName.AddStudent:
                //    controlName = "ctlAddStudent";
                //    break;
                //case ControlName.ManageStudent:
                //    controlName = "ctlManageStudent";
                //    break;
                //case ControlName.AddTeacher:
                //    controlName = "ctlAddTeacher";
                //    break;
                //case ControlName.ManageTeacher:
                //    controlName = "ctlManageTeacher";
                //    break;
                //case ControlName.TimeTable:
                //    controlName = "ctlTimeTable";
                //    break;
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