using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DatabaseAccessLayer.Operations;

namespace TravelSite.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CardDal cardDal = new CardDal();
            var cards = cardDal.GetPictures();
            PicturesList.DataSource = cards;
            PicturesList.DataBind();

            VideoDal videoDal = new VideoDal();
            var videos = videoDal.GetVideos();
            VideosList.DataSource = videos;
            VideosList.DataBind();
        }
    }
}