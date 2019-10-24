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
        Player player1;
        Player player2;

        //constructor (Spawner)

        //member methods (Can Do)
        public void DisplayRules()
        {
            Console.WriteLine("Rules of the game: \n" +
            "This 2-player game consists of \"Shooting\" gestures. \n" +
            "The possible gestures are rock, paper, scissors, lizard, and spock. Certain gestures beat other gestures. Whichever gseture beats the other, wins the round. \n" +
            "The following explains which gestures beat other gestures: \n" +
            "\n" +
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
        public string ChoosePlayers()
        {
            Console.WriteLine("How many players would you like to have?");
            string playerNum = Console.ReadLine();
            Console.WriteLine(playerNum);
            return playerNum;
        }
        public void CreatePlayers(string numberOfPlayers)
        {
            if (numberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new ComputerPlayer();
            }
            else if (numberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("I'm sorry, this is only a 2 player game. \n" +
                "Please select either 1 or 2 players. Gestures will be randomly decided \nfor the other player if 1 is typed in.");
            }
        }

        
        public void DisplayOptions()
        {
            Console.WriteLine("What would you like to shoot? \n Rock \n Paper \n Scissors \n Lizard \n Spock");
            Console.ReadLine();
        }

        public void RunGame()
        {
            string numberOfPlayers = ChoosePlayers();
            CreatePlayers(numberOfPlayers);
            player1.playerChoice();
            player2.playerChoice();
        }
    }
}
