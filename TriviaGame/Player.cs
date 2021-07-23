using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    public class Player
    {
        public int highScore { get; set; }
        public string name { get; set; }

        public Player() { }
        public Player(int score, string displayName)
        {
            highScore = score;
            name = displayName;
        }
    }   
}
