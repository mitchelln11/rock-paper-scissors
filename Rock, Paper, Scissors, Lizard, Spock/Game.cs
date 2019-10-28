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
        string rematch;

        //constructor (Spawner)

        //member methods (Can Do)
        public void DisplayRules()
        {
            Console.WriteLine("Rules of the game: \n" +
            "This 2-player game consists of \"Shooting\" gestures. \n" +
            "The winner is decided in best-of-three rounds \n" +
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
            string playerNum = Console.ReadLine().Replace(" ", "").Trim();

            if (playerNum == "1")
            {
                player1 = new Human();
                player2 = new ComputerPlayer();
            }
            else if (playerNum == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("I'm sorry, this is only a 2 player game. \n" +
                "Please select either 1 or 2 players. Gestures will be randomly decided \nfor the other player if 1 is typed in.");
                CreatePlayers();
            }
            //Putting after if statements because they both run no matter what
            player1.ChooseName();
            player2.ChooseName();
        }

        public void Versus()
        {
            Console.WriteLine("\n" + player1.name + " vs " + player2.name + "\n");
        }

        public void DisplayOptions()
        {
            Console.WriteLine("What would you like to shoot? \n rock \n paper \n scissors \n lizard \n spock \n");
        }

        public void CompareScores()
        {
            if ((player1.answer == "rock") && ((player2.answer == "scissors") || (player2.answer == "lizard")))
            {
                Console.WriteLine(player1.name + " wins this round! \n");
                player1.score++;
            }
            else if ( (player1.answer == "paper") && ((player2.answer == "rock") || (player2.answer == "spock")) )
            {
                Console.WriteLine(player1.name + " wins this round! \n");
                player1.score++;
            }
            else if ((player1.answer == "scissors") && ((player2.answer == "paper") || (player2.answer == "lizard")))
            {
                Console.WriteLine(player1.name + " wins this round! \n");
                player1.score++;
            }
            else if ((player1.answer == "lizard") && ((player2.answer == "paper") || (player2.answer == "spock")))
            {
                Console.WriteLine(player1.name + " wins this round! \n");
                player1.score++;
            }
            else if ((player1.answer == "spock") && ((player2.answer == "scissors") || (player2.answer == "rock")))
            {
                Console.WriteLine(player1.name + " wins this round! \n");
                player1.score++;
            }
            else if (player1.answer == player2.answer)
            {
                Console.WriteLine("This round is a tie! \n");
            }
            else
            {
                Console.WriteLine(player2.name + " wins this round! \n");
                player2.score++;
            }
            Console.WriteLine(player1.name + " " + player1.score + " " + player2.name + " " + player2.score);
        }

        public void DetermineWinner()
        {
            int winnerNumber = 2;
            if(player1.score >= winnerNumber)
            {
                Console.WriteLine(player1.name + " Wins \n");
            }
            else if (player2.score >= winnerNumber)
            {
                Console.WriteLine(player2.name + " Wins \n");
            }
        }

        public void Rematch()
        {
            Console.WriteLine("Rematch? Enter Y to play again, enter N to leave.");
            player1.score = 0;
            player2.score = 0;
            rematch = Console.ReadLine().Trim().ToLower();
            if ( (rematch == "y") || (rematch == "yes") )
            {
                RunGame();
            }
            else if ((rematch == "n") || ( (rematch == "no") ) )
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Could not recognize \" " + rematch + " \" Try Y to replay, or N to quit.");
                Rematch();
            }
        }

        // Implementing after a game is complete in order to reset
        public void RunGame()
        {
            //setup
            Versus();
            DisplayOptions();

            // loop
            while (player1.score < 2 && player2.score < 2)
            {
                player1.playerChoice();
                player2.playerChoice();
                CompareScores();
                DetermineWinner();
            }

            Rematch();
            Console.ReadLine();
            //}
        }
    }
}
