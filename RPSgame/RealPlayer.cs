using System;
using System.Collections.Generic;
using System.Text;

namespace RPSgame
{
    class RealPlayer : Players
    {

        // member variables (HAS A)
        public int choice;
        
        // Constructor
        public RealPlayer()
        {

        }

        // member methods
        public override  int ChooseGesture()
        {

            do
            {
                string input;

                Console.WriteLine("Decide Your move. Type: ROCK/PAPER/SCISSORS/LIZARD/SPOCK");
                input = Console.ReadLine();
                switch (input)
                {

                    case "ROCK":
                        choice = 1;
                        break;
                    case "PAPER":
                        choice = 2;
                        break;
                    case "SCISSORS":
                        choice = 3;
                        break;
                    case "LIZARD":
                        choice = 4;
                        break;
                    case "SPOCK":
                        choice = 5;
                        break;
                    default:
                        Console.WriteLine("Please Enter A Valid Gesture");
                        break;
                }

                // return (choice);

            } while (choice != 1 && choice != 2 && choice != 3 && choice != 4 && choice != 5);

        }
        public override string NamePlayer()
        {
            Console.WriteLine("Please Enter Your Name");
            namePlayer = Console.ReadLine();
            return namePlayer;
        }



















    }




}

