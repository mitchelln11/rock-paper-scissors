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
            gameOptions.displayRules();
            gameOptions.choosePlayers();
            gameOptions.displayOptions();
            

            Human playeroptions = new Human();

            ComputerPlayer decision = new ComputerPlayer();
            decision.playerChoice();
        }
    }
}
