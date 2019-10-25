using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public class Human : Player
    {
        //member variables (Has A)
        public int playOptionsCount;


        // member methods (CAN DO)
        public override void ChooseName()
        {
            Console.WriteLine("Choose Name");
            name = Console.ReadLine().Replace(" ", "").Trim();
        }

        public override void playerChoice()
        {
            Console.WriteLine("Choose Gesture " + name);
            answer = Console.ReadLine().Replace(" ", "").Trim().ToLower();
            if ( (answer != "rock") && (answer != "paper") && (answer != "scissors") && (answer != "lizard") && (answer != "spock")) 
            {
                Console.WriteLine("I'm sorry. The only options are rock, paper, scissors, lizard, or spock. Please try again.");
                playerChoice();
            }
            Console.WriteLine(name + " chose " + answer);
        }



        



    }
}
