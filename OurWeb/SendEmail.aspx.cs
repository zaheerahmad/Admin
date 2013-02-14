using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTD.Common;
using System.Net.Mail;
using System.Net;
using System.Configuration;
using System.Text;


namespace OurWeb
{
    public partial class SendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Utility.GetParameter("name");
            string email = Utility.GetParameter("email");
            string message = Utility.GetParameter("message");
            ReceiveEmailFromWebsite(name, email, message);
            Response.Redirect("Home.aspx?ctl=3");

            
        }

        public void ReceiveEmailFromWebsite(string pName, string pEmail, string pMessage)
        {
            string senderEmail = ConfigurationManager.AppSettings.Get("AdministratorEmail");
            string password = ConfigurationManager.AppSettings.Get("AdministratorEmailPassword");
            MailMessage mail = new MailMessage();
            mail.From = new System.Net.Mail.MailAddress(senderEmail);

            // The important part -- configuring the SMTP client
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;   // [1] You can try with 465 also, I always used 587 and got success
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // [2] Added this
            smtp.UseDefaultCredentials = false; // [3] Changed this
            smtp.Credentials = new NetworkCredential(mail.From.Address, password);// [4] Added this. Note, first parameter is NOT string.
            smtp.Host = "smtp.gmail.com";
            StringBuilder body = new StringBuilder();
            body.Append("<h1>Message from WebSite</h1>");
            body.Append("<p><h3>Sender:</h3>");
            body.Append(pEmail + "<br />");
            body.Append("<h3>Name:</h3>");
            body.Append(pName + "<br />");
            body.Append("<h3>Message:</h3>");
            body.Append(pMessage + "<br /></p>");

            //recipient address
            mail.To.Add(new MailAddress("zaheer.ahmad@northbaysolutions.net"));
            mail.Subject = "Dummy Message";
            mail.Body = body.ToString();
            ////Formatted mail body
            mail.IsBodyHtml = true;
            //string st = "Test";

            //mail.Body = st;
            smtp.Send(mail);
        }
    }
}