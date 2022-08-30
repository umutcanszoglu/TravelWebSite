using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccessLayer.Operations;
using Models;

namespace TravelSite.Pages
{
    public partial class Admin : System.Web.UI.Page
    {
        AdminDal adminDal = new AdminDal();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            if (ImageUpload.HasFile)
            {
                var path = Server.MapPath("/Pictures/");

                ImageUpload.SaveAs(path + ImageUpload.FileName);

                adminDal.ImageAdd(new Picture
                {
                    Text = txtText.Text,
                    Title = txtTitle.Text,
                    Pic = "/Pictures/" + ImageUpload.FileName
                });
            }
        }

        protected void btnDel_OnClick(object sender, EventArgs e)
        {
            var pic = adminDal.GetPictureById(Int32.Parse(txtDel.Text));
            adminDal.ImageDelete(pic);
        }

        protected void btnShow_OnClick(object sender, EventArgs e)
        {
            CardDal cardDal = new CardDal();
            var cards = cardDal.GetPictures();
            ImageList.DataSource = cards;
            ImageList.DataBind();
        }

        protected void btnVideo_OnClick(object sender, EventArgs e)
        {
            var videourl_1 = "https://www.youtube.com/embed/";
            var videourl_2 = "?rel=0";

            VideoDal videoDal = new VideoDal();
            var currentVideo = videoDal.GetById();
            currentVideo.Url = videourl_1 + txtUrl.Text + videourl_2;
            videoDal.Update(currentVideo);
        }

        protected void btnFormShow_Click(object sender, EventArgs e)
        {
            ApplicationFormDal formDal = new ApplicationFormDal();

            var users = formDal.getForms();
            ListView1.DataSource = users;
            ListView1.DataBind();
        }

        protected void btnFormDel_Click(object sender, EventArgs e)
        {
            ApplicationFormDal formDal = new ApplicationFormDal();
            var form = formDal.getbyEmail(txtFormDel.Text);
            formDal.Delete(form);
        }
    }
}