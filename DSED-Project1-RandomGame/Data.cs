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
        public int counter { get; set; } = 6;
        public int win { get; set; } = 0;
        public int lose { get; set; } = 0;
        public int dice { get; set; }
        public int ProtectJacket { get; set; } = 2;
        public bool IsFiringThisTurn { get; set; } = false;
    }
}
