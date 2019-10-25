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
            Game game = new Game();
            game.DisplayRules();
            game.CreatePlayers();
            game.RunGame();
        }
    }
}
