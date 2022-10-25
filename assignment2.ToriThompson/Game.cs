using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tori Thompson
//Wheel of fortune game class

namespace assignment2.ToriThompson
{    
    class Game
    {
        public const int SIZE = 26;
        public string[] TargetWords { get; set; }
        public int[] PrizeAmts { get; set; }
        public string CurrentWord { get; set; }
        public int CurrentPrize { get; set; }

        public int PlayerTurn { get; set; }

        public char[] GuessedLetter { get; set; }

        public Game()
        {
            TargetWords = new String[] { "cool beans", "crystal clear", "deja vu", "fancy that", "game on" };
            PrizeAmts = new int[] { 5000, 500, 300, 900, 600 };
            CurrentWord = "";
            randWord();
            PlayerTurn = 0;
            GuessedLetter = new Char[SIZE];
        }

        public void randWord()
        {
            Random randomNum = new Random();
            int randNum = randomNum.Next() % TargetWords.Length;
            CurrentWord = TargetWords[randNum];
        }
    }
}
