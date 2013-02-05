using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdminSite.Model;
using System.IO;
using TTD.Common;

namespace AdminSite.Controls
{
    public partial class ctlAddServices : System.Web.UI.UserControl
    {
        int serviceId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            serviceId = Utility.GetIntParameter("id");
            if (serviceId > 0)
            {
                LoadService(serviceId);
            }
        }

        protected void btnAddService_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                if (serviceId > 0)
                {
                    Service service = new Service(serviceId);
                    service.IsNew = false;

                    service.ServiceTitle = txtServiceTitle.Text;
                    service.ServiceDescription = txtServiceDescription.Text;
                    service.Save();
                    lblStatus.Text = Global.UpdatedLabelStatus;
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                    Save();
            }
            
        }

        string UploadPrintableFile(Service service)
        {

            string NewFileName = service.ServiceId + "-" + Path.GetFileName(fuServicePicture.PostedFile.FileName);
            string FileNameWithoutExt = service.ServiceId + "-" + Path.GetFileNameWithoutExtension(fuServicePicture.PostedFile.FileName);
            string error;
            if (fuServicePicture.PostedFile.ContentLength > 1)
            {
                Utility.DeleteFile(Global.ServicesImages + service.ServiceImage);
                if (Utility.UploadFile(fuServicePicture, FileNameWithoutExt, Global.ServicesImages, out error))
                {
                    service = new Service(Service.Columns.ServiceId, service.ServiceId);
                    service.IsNew = false;
                    service.ServiceImage = NewFileName;
                    service.Save(Guid.NewGuid());
                }
                else
                {
                    Service.Destroy(service.ServiceId);
                    return error.ToString();
                }
            }
            return String.Empty;
        } // Upload file ends here 

        public void ClearForm()
        {
            txtServiceTitle.Text = "";
            txtServiceDescription.Text = "";
            fuServicePicture.Dispose();
        }

        public void LoadService(int pServiceId)
        {
            Service service = new Service(pServiceId);
            txtServiceTitle.Text = service.ServiceTitle;
            txtServiceDescription.Text = service.ServiceDescription;
        }

        public void Save()
        {
            string serviceTitle = txtServiceTitle.Text;
            string serviceDescription = txtServiceDescription.Text;

            Service service = new Service();
            service.IsNew = true;
            service.ServiceTitle = serviceTitle;
            service.ServiceDescription = serviceDescription;
            service.Save();

            //Now Save Picture As Well..
            string result = UploadPrintableFile(service);
            if (result.Equals(""))
            {
                lblStatus.Text = Global.SuccessLabelStatus;
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = Global.ErrorLabelStatus + result;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            ClearForm();
        }

    }
}