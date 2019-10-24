using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    class Program
    {
        static void Main(string[] args)
        {
            Game gameOptions = new Game();
            gameOptions.DisplayRules();
            //string worstPlayer = gameOptions.ChoosePlayers(); // If I wanted a second parameter, I would have to attach a string a second time
            // gameOptions.CreatePlayers(numberOfPlayers, worstPlayer); //Way to reference 2 parameters
            string numberOfPlayers = gameOptions.ChoosePlayers();
            gameOptions.CreatePlayers(numberOfPlayers); //Way to reference 2 parameters
            

            // Could also call this way when referencing abstract classes:
            // Player playerOptions = new Human();
            Human playerOptions = new Human();
            playerOptions.ChooseName();

            gameOptions.DisplayOptions();

            ComputerPlayer decision = new ComputerPlayer();
            decision.playerChoice();
        }
    }
}
