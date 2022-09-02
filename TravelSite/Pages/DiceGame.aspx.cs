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
    public partial class DiceGame : System.Web.UI.Page
    {
        DiceDal diceDal = new DiceDal();
        protected void Page_Load(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();

            DiceView.DataSource = dices;
            DiceView.DataBind();
            LblTotal.Text = diceDal.TotalScore(dices).ToString();
        }


        protected void btnRoll_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();

            DiceView.DataSource = dices;
            DiceView.DataBind();

            diceDal.Roll(dices);

        }

        protected void btnAdd_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();


            for (int i = 0; i < dices.Count; i++)
            {
                



            }

            
        }
    }
}