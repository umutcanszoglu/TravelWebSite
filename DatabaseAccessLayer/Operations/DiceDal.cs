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

        public List<int> GetFaces()
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                var diceList = GetDices();
                List<int> faces = new List<int>(diceList.Count);

                for (int i = 0; i < diceList.Count; i++)
                {
                    faces.Add(diceList[i].Face);
                }

                return faces;
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

        public int Salary(List<Dice> diceList)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                return 1;
            }
        }

        public void Upgrade(Dice dice)
        {
            using (TravelDBContext ctx = new TravelDBContext())
            {
                dice.Level += 1;

                var entity = ctx.Entry(dice);
                entity.State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
