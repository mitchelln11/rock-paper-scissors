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

        public void CreatePlayers()
        {
            //get input for #
            Console.WriteLine("How many players would you like to have?");
            string playerNum = Console.ReadLine();

            if (playerNum == "1")
            {
                player1 = new Human();
                player2 = new ComputerPlayer();
                player1.ChooseName();
                player2.playerChoice();
            }
            else if (playerNum == "2")
            {
                player1 = new Human();
                player2 = new Human();
                player1.ChooseName();
                player2.ChooseName();
            }
            else
            {
                Console.WriteLine("I'm sorry, this is only a 2 player game. \n" +
                "Please select either 1 or 2 players. Gestures will be randomly decided \nfor the other player if 1 is typed in.");
                CreatePlayers();
            }
            
        }


        public void DisplayOptions()
        {
            Console.WriteLine("What would you like to shoot? \n rock \n paper \n scissors \n lizard \n spock \n");
            string option = Console.ReadLine();
            Console.WriteLine("You chose " + option);
            // Console.ReadLine(); //Uncomment if you want the program to stop with the terminal open
        }

        public void CalculateScores(string player1Ans, string player2Ans)
        {
            Console.WriteLine("testing for stop");
            Console.ReadLine();
        }

        public void DetermineWinner()
        {
            if(player1.score >=2)
            {
                Console.WriteLine(player1.name + "Wins");
            }
            else if (player2.score >= 2)
            {
                Console.WriteLine(player2.name + "Wins");
            }
        }

        // Implementing after a game is complete in order to reset
        public void RunGame()
        {
            //setup
            DisplayRules();
            CreatePlayers();
            DisplayOptions();

            // loop
            //while (player1.score < 2 && player2.score < 2)
            //{
            //    player1.playerChoice();
            //    player2.playerChoice();
            //}

            //DetermineRoundWinner(player1, player2)
            //if (player1.score == 2)
            //{
            //    DetermineWinner();
            //    Console.ReadLine();
            //}
            //else if (player2.score == 2)
            //{
            //    DetermineWinner();
            //    Console.ReadLine();
            //}
        }
    }
}
