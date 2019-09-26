using System;
using System.Collections.Generic;
using System.Text;

namespace RPSgame
{
    class RealPlayer : Players
    {

        // member variables (HAS A)
   
        // Constructor
        public RealPlayer()
        {

        }

        // member methods
        public override int ChooseGesture()
        {

        }
        public override string NamePlayer()
        {
            Console.WriteLine("Please Enter Your Name");
            namePlayer = Console.ReadLine();
            return namePlayer;
        }



















    }




}

