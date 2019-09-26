using System;
using System.Collections.Generic;
using System.Text;

namespace RPSgame
{
    abstract class Players
    {
        // member variables (HAS A)
        public int gesture;
        public string namePlayer;
        public int score;
        //Constructor

        public Players()
            {
                score = 0;
            }
        //member methods (can do)
        public abstract string NamePlayer();

        public abstract int ChooseGesture();

    }
}
