using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseAccessLayer.Operations
{
    public class DiceDal
    {
        public List<Dice> GetDices()
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                return ctx.Dices.ToList();
            }
        }

        public void Roll(List<Dice> diceList)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                List<string> icons = new List<string>
                {
                    "⚀", "⚁", "⚂", "⚃", "⚄", "⚅"
                };
                Random random = new Random();
                for (int i = 0; i < diceList.Count; i++)
                {
                    var number = random.Next(0, 5);

                    diceList[i].DiceString = icons[number];
                    diceList[i].Face = number + 1;
                    diceList[i].Score = diceList[i].Face * diceList[i].Multipy;

                    var entity = ctx.Entry(diceList[i]);
                    entity.State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }
        

        public int TotalScore(List<Dice> diceList)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                var total = 0;
                for (int i = 0; i < diceList.Count; i++)
                {
                    total += diceList[i].Score;
                }
                return total;
            }
        }

        public void Upgrade(List<Dice> diceList)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                for (int i = 0; i < diceList.Count; i++)
                {
                    diceList[i].Level += 1;

                    var entity = ctx.Entry(diceList[i]);
                    entity.State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
        }
    }
}
