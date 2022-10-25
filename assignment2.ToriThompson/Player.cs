using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tori Thompson
//Wheel of fortune player class

namespace assignment2.ToriThompson
{
    class Player
    {
        public string PlayerName { get; set; }
        public int PlayerScore { get; set; }
        public int NumWins { get; set; }
        public int NumLoss { get; set; }

        public Player(string passedName)
        {
            PlayerName = passedName;
            PlayerScore = 0;
            NumWins = 0;
            NumLoss = 0;
        }
    }
}
