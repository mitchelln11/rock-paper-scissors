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


        // constructor


        // member methods (CAN DO)

        //Over-riding abstract value from Players class
        public override void roboChoice()
        {
            Console.WriteLine("testing");
            foreach (string options in playOptions)
            {
                choice = new Random();
                //string randomNum = choice.Next(1, options + 1);
                Console.WriteLine(options);
            }
            
            Console.ReadLine();
        }

    }
}
