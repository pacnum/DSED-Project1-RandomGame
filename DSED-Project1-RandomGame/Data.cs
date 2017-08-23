using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSED_Project1_RandomGame
{
    class Data
    {
        // public int counter = 6;
        // public int win = 0;
        // public int lose = 0;
        // public int dice;
        // public int ProtectJacket = 2;
        //public bool IsFiringThisTurn = false;
        public int Counter { get; set; } = 6;
        public int Win { get; set; } = 0;
        public int Lose { get; set; } = 0;
        public int Dice { get; set; }
        public int ProtectJacket { get; set; } = 2;
        public bool IsFiringThisTurn { get; set; } = false;

        public void RNDGenerator()
        {
            Random rnd = new Random();
            Dice = rnd.Next(1, 7); // Random Number between 1 and <7


        }
    }
}
