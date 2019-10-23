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
        //public Random choice;


        // constructor


        // member methods (CAN DO)
        public ComputerPlayer()
        {

        }
        //Over-riding abstract value from Players class
        public override void roboChoice()
        {
            Console.WriteLine("testing");
            Console.WriteLine(playOptions);
            Console.ReadLine();
        }

    }
}
