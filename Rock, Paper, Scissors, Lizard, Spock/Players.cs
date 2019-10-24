using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public abstract class Players
    {
        //member variables (Has A)
        public List<string> playOptions;

        //constructor (Spawner)
        public Players()
        {
            playOptions = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        }

        public abstract void playerChoice();



        //member methods (Can Do)


        public void displayResponse()
        {
            string playerDecision = Console.ReadLine();
            Console.WriteLine("You chose: " + playerDecision);
            Console.ReadLine();
        }
    }
}
