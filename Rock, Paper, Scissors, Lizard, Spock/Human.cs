using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public class Human : Player
    {
        //member variables (Has A)

        //constructors


        //public Human()
        //{

        //}

        // member methods (CAN DO)
        public override void ChooseName()
        {
            Console.WriteLine("Choose Name");
            name = Console.ReadLine();
        }

        public override void playerChoice()
        {
            Console.WriteLine("Choose Gesture");
            answer = Console.ReadLine();
        }
    }
}
