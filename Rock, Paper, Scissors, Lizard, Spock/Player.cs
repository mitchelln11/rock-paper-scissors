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
        public string names;
        public int score;

        //constructor (Spawner)
        public Player()
        {
            playOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            score = 0;
        }


        //member methods (Can Do)
        public virtual void ChooseName()
        {
            Console.WriteLine("Choose Name");
            string name1 = Console.ReadLine();
            Console.WriteLine(name1);
        }

        public abstract void playerChoice();


        public void displayResponse()
        {
            string playerDecision = Console.ReadLine();
            Console.WriteLine("You chose: " + playerDecision);
            Console.ReadLine();
        }
    }
}
