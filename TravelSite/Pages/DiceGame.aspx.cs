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
        LogDal logDal = new LogDal();
        protected void Page_Load(object sender, EventArgs e)
        {
            Show();
        }

        protected void btnRoll_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();
            
            diceDal.Roll(dices);

            var list = diceDal.GetFaces();

            logDal.Log(new Log
            {
                Date = DateTime.Now,
                Roll = "Rolled!",
                Dice1 = list[0],
                Dice2 = list[1],
                Dice3 = list[2],
                Dice4 = list[3],
                Dice5 = list[4]
            });

            Show();
        }

        protected void btnUp1_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();
            diceDal.Upgrade(dices[0]);
            Show();

            logDal.Log(new Log
            {
                FirstUpgrade = "Upgraded!"
            });
        }

        protected void btnUp2_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();
            diceDal.Upgrade(dices[1]);
            Show();

            logDal.Log(new Log
            {
                SecondUpgrade = "Upgraded!"
            });
        }

        protected void btnUp3_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();
            diceDal.Upgrade(dices[2]);
            Show();
            logDal.Log(new Log
            {
                ThirdUpgrade = "Upgraded!"
            });
        }

        protected void btnUp4_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();
            diceDal.Upgrade(dices[3]);
            Show();
            logDal.Log(new Log
            {
                FourthUpgrade = "Upgraded!"
            });
        }

        protected void btnUp5_OnClick(object sender, EventArgs e)
        {
            var dices = diceDal.GetDices();
            diceDal.Upgrade(dices[4]);
            Show();
            logDal.Log(new Log
            {
                FifthUpgrade = "Upgraded!"
            });
        }
        public void Show()
        {
            var dices = diceDal.GetDices();
            DiceView.DataSource = dices;
            DiceView.DataBind();
        }
    }
}