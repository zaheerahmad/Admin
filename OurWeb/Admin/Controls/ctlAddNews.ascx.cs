using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TTD.Common;
using AdminSite.Model;
using System.IO;

namespace AdminSite.Controls
{
    public partial class ctlAddNews : System.Web.UI.UserControl
    {
        int newsId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            divStatusError.Visible = false;
            divStatusSuccess.Visible = false;
            newsId = Utility.GetIntParameter("id");
            if (newsId > 0)
            {
                LoadNews(newsId);
            }
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                if (newsId > 0)
                {
                    News news = new News(newsId);
                    news.IsNew = false;

                    news.NewsTitle = txtNewsTitle.Text;
                    news.NewsDescription = txtNewsDescription.Text;
                    try
                    {
                        news.Save();
                        UploadPrintableFile(news);
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

        string UploadPrintableFile(News news)
        {

            string NewFileName = news.NewsId + "-" + Path.GetFileName(fuNewsPicture.PostedFile.FileName);
            string FileNameWithoutExt = news.NewsId + "-" + Path.GetFileNameWithoutExtension(fuNewsPicture.PostedFile.FileName);
            string error;
            if (fuNewsPicture.PostedFile.FileName == null || fuNewsPicture.PostedFile.FileName.Equals("") && newsId == 0)
            {
                news = new News(News.Columns.NewsId, news.NewsId);
                news.IsNew = false;
                news.NewsImage = "NoImage.jpg";
                news.Save(Guid.NewGuid());
                return string.Empty;
            }
            if (fuNewsPicture.PostedFile.ContentLength > 1)
            {
                Utility.DeleteFile(Global.NewsImages + news.NewsImage);
                if (Utility.UploadFile(fuNewsPicture, FileNameWithoutExt, Global.NewsImages, out error))
                {
                    news = new News(News.Columns.NewsId, news.NewsId);
                    news.IsNew = false;
                    news.NewsImage = NewFileName;
                    news.Save(Guid.NewGuid());
                }
                else
                {
                    News.Destroy(news.NewsId);
                    return error.ToString();
                }
            }
            return String.Empty;
        } // Upload file ends here 

        public void ClearForm()
        {
            txtNewsTitle.Text = "";
            txtNewsDescription.Text = "";
            fuNewsPicture.Dispose();
        }

        public void LoadNews(int pNewsId)
        {
            News news = new News(pNewsId);
            txtNewsTitle.Text = news.NewsTitle;
            txtNewsDescription.Text = news.NewsDescription;
        }

        public void Save()
        {
            string newsTitle = txtNewsTitle.Text;
            string newsDescription = txtNewsDescription.Text;

            News news = new News();
            news.IsNew = true;
            news.NewsTitle = newsTitle;
            news.NewsDescription = newsDescription;
            news.Save();

            //Now Save Picture As Well..
            string result = UploadPrintableFile(news);
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