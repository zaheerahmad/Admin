using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTD.Common;
using OurWeb.Model;
using System.IO;

namespace AdminSite.Controls
{
    public partial class ctlAddClient : System.Web.UI.UserControl
    {
        int clientId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            divStatusError.Visible = false;
            divStatusSuccess.Visible = false;
            clientId = Utility.GetIntParameter("id");
            if (clientId > 0)
            {
                LoadClient(clientId);
            }
        }

        protected void btnAddClient_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                if (clientId > 0)
                {
                    Client client = new Client(clientId);
                    client.IsNew = false;

                    client.ClientName = txtClientName.Text;
                    client.ClientDescription = txtDescription.Text;
                    client.ClientAddress = txtAddress.Text;
                    client.ClientContactPerson = txtContactPerson.Text;
                    client.ClientContactNo = txtContactNo.Text;
                    client.ClientURL = txtClientURL.Text;
                    try
                    {
                        client.Save();
                        UploadPrintableFile(client);
                        divStatusError.Visible = false;
                        divStatusSuccess.Visible = true;
                        lblStatusSuccess.Text = Global.UpdatedLabelStatus;
                        //lblStatusSuccess.ForeColor = System.Drawing.Color.Green;
                    }
                    catch (Exception ex)
                    {
                        divStatusSuccess.Visible = false;
                        divStatusError.Visible = true;
                        labelStatusError.Text = Global.ErrorLabelStatus + ex.ToString();
                        //labelStatusError.ForeColor = System.Drawing.Color.Red;
                    }
                }
                else
                {
                    try
                    {
                        Save();
                    }
                    catch (Exception ex)
                    {
                        divStatusSuccess.Visible = false;
                        divStatusError.Visible = true;
                        labelStatusError.Text = Global.ErrorLabelStatus + ex.ToString();
                    }
                }
            }

        }

        string UploadPrintableFile(Client client)
        {
            string NewFileName = client.ClientId + "-" + Path.GetFileName(fuLogo.PostedFile.FileName);
            string FileNameWithoutExt = client.ClientId + "-" + Path.GetFileNameWithoutExtension(fuLogo.PostedFile.FileName);
            string error;
            if (fuLogo.PostedFile.FileName == null || fuLogo.PostedFile.FileName.Equals("") && clientId == 0)
            {
                client = new Client(Client.Columns.ClientId, client.ClientId);
                client.IsNew = false;
                client.ClientLogo = "NoImage.jpg";
                client.Save(Guid.NewGuid());
                return string.Empty;
            }
            if (fuLogo.PostedFile.ContentLength > 1)
            {
                Utility.DeleteFile(Global.NewsImages + client.ClientLogo);
                if (Utility.UploadFile(fuLogo, FileNameWithoutExt, Global.ClientLogos, out error))
                {
                    client = new Client(Client.Columns.ClientId, client.ClientId);
                    client.IsNew = false;
                    client.ClientLogo = NewFileName;
                    client.Save(Guid.NewGuid());
                }
                else
                {
                    Client.Destroy(client.ClientId);
                    return error.ToString();
                }
            }
            return String.Empty;
        } // Upload file ends here 

        public void ClearForm()
        {
            txtClientName.Text = "";
            txtDescription.Text = "";
            txtAddress.Text = "";
            txtContactPerson.Text = "";
            txtContactNo.Text = "";
            txtClientURL.Text = "";
            fuLogo.Dispose();
        }

        public void LoadClient(int pClientId)
        {
            Client client = new Client(pClientId);
            txtClientName.Text = client.ClientName;
            txtDescription.Text = client.ClientDescription;
            txtAddress.Text = client.ClientAddress;
            txtContactPerson.Text = client.ClientContactPerson;
            txtContactNo.Text = client.ClientContactNo;
            txtClientURL.Text = client.ClientURL;
        }

        public void Save()
        {
            Client client = new Client();
            client.IsNew = true;
            client.ClientName = txtClientName.Text;
            client.ClientDescription = txtDescription.Text;
            client.ClientAddress = txtAddress.Text;
            client.ClientContactPerson = txtContactPerson.Text;
            client.ClientContactNo = txtContactNo.Text;
            client.ClientURL = txtClientURL.Text;
            client.Save();

            //Now Save Picture As Well..
            string result = UploadPrintableFile(client);
            if (result.Equals(""))
            {
                divStatusError.Visible = false;
                divStatusSuccess.Visible = true;
                lblStatusSuccess.Text = Global.SuccessLabelStatus;
                //lblStatusSuccess.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                divStatusSuccess.Visible = false;
                divStatusError.Visible = true;
                labelStatusError.Text = Global.ErrorLabelStatus + result;
                //labelStatusError.ForeColor = System.Drawing.Color.Red;
            }
            ClearForm();
        }
    }
}