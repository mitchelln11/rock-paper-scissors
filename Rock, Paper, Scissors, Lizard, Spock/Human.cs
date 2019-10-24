using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors__Lizard__Spock
{
    public class Human : Player
    {
        //constructors


        //public Human()
        //{

        //}

        // member methods (CAN DO)
        
        public override void playerChoice()
        {
            Console.WriteLine("Choose Gesture");
            string gesture = Console.ReadLine();
            Console.WriteLine(gesture);
        }
    }
}
