using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public class ComputerPlayer : Players
    {
        //member variables (Has A)
        private Random choice;
        public int playOptionsCount;

        // constructor
        public ComputerPlayer()
        {
            choice = new Random(); //random value
            playOptionsCount = playOptions.Count; //length of list items
        }

        // member methods (CAN DO)

        //Over-riding abstract value from Players class
        public override void playerChoice()
        {
            int aiSelection = choice.Next(playOptionsCount);//tie random choice with length of items  
            Console.WriteLine(playOptions[aiSelection]);
            Console.WriteLine(playOptionsCount);
            Console.ReadLine();
        }
    }
}
