using System;
using System.Collections.Generic;
using System.Text;

namespace RPSgame
{
    class GameSet
    {
        // member variables (HAS A)
        public int pvp;
        public int pve;
        int input;
        // Constructor
        public GameSet()
        {

        }
        //member methods
        public void RunGame()
        {
            GameType();
        }
       
        public void GameType()
        {

            
            do
            {
                string input;
                Console.WriteLine("Ya playin with yaself ya incel? Or ya got two to tango baby?");
                input = Console.ReadLine();
                switch (input)
                {
                    case "pvp":
                        pvp = 2;
                        break;
                    case "pve":
                        pve = 1;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid gametype.");
                        break;
                } 
            } while (pvp != 2 && pve != 1);
            

           





        }


    }
}
        