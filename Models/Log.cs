using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Roll { get; set; }
        public string FirstUpgrade { get; set; }
        public string SecondUpgrade { get; set; }
        public string ThirdUpgrade { get; set; }
        public string FourthUpgrade { get; set; }
        public string FifthUpgrade { get; set; }
        public int Dice1 { get; set; }
        public int Dice2 { get; set; }
        public int Dice3 { get; set; }
        public int Dice4 { get; set; }
        public int Dice5 { get; set; }
    }
}
