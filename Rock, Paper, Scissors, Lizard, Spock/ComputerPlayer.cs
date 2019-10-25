using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public class ComputerPlayer : Player
    {
        //member variables (Has A)
        private Random rand;
        public int playOptionsCount;

        // constructor
        public ComputerPlayer()
        {
            rand = new Random(); //random value
            playOptionsCount = playOptions.Count; //length of list items
        }
        // member methods (CAN DO)
        public override void ChooseName()
        {
            name = "Johnny Five"; // Setting to a string because console logging, then assigning response, assigns the Enter (space) instead of the hardcoded value
        }

        //Over-riding abstract value from Players class
        public override void playerChoice()
        {
            int aiSelection = rand.Next(playOptionsCount);//tie random choice with length of items
            Console.WriteLine(name + " chose " + playOptions[aiSelection] + " \n");
            answer = playOptions[aiSelection];
        }
    }
}
