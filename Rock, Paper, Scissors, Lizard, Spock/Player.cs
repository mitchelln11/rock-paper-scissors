using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public abstract class Player
    {
        //member variables (Has A)
        public List<string> playOptions;
        public string name;
        public string answer;
        public int score;

        //constructor (Spawner)
        public Player()
        {
            playOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            score = 0;
        }


        //member methods (Can Do)
        public abstract void ChooseName();

        public abstract void playerChoice();
    }
}
