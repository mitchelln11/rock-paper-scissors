using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    class Game
    {
        //member variables (Has A)
        //private string Player player1;
        //private string Player player2;

        //constructor (Spawner)

        //member methods (Can Do)

        public void choosePlayers()
        {
            Console.WriteLine("How many players would you like to have?");
        }

            public void displayRules()
        {
            Console.WriteLine("Rules of the game: \n This 2-player game consists of \"Shooting\" gestures. \n" +
                "The possible gestures are rock, paper, scissors, lizard, and spock. Certain gestures beat other gestures. Whichever gseture beats the other, wins the round. \n" +
                "The following explains which gestures beat other gestures: \n" +
                "Rock crushes Scissors \n" +
                "Scissors cuts Paper \n" +
                "Paper covers Rock \n" +
                "Rock crushes Lizard \n" +
                "Lizard poisons Spock \n" +
                "Spock smashes Scissors \n" +
                "Scissors decapitates Lizard \n" +
                "Lizard eats Paper \n" +
                "Paper disproves Spock \n" +
                "Spock vaporizes Rock \n");
        }
        public void displayOptions()
        {
            Console.WriteLine("What would you like to shoot? \n Rock \n Paper \n Scissors \n Lizard \n Spock");
            Console.ReadLine();
        }
    }
}
