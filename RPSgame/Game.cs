using System;
using System.Collections.Generic;
using System.Text;

namespace RPSgame
{
    class Game
    {
        // member variables (HAS A)
        GameSet gameset;

        public Players playerOne;
        public Players playerTwo;
        
        
        
        // Constructor

            public Game()
        {
            gameset = new GameSet();
        }

        //member methods (can do)
        public void RunGame() //master method
        {
            
            DisplayRules();
            gameset.RunGame();
            CreatePlayers(gameset.pvp);
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();




        }

        public void DisplayRules()
        {
            Console.WriteLine(" Rock crushes Scissors ");
            Console.WriteLine(" Scissors cuts Paper ");
            Console.WriteLine(" Paper Covers Rock ");
            Console.WriteLine(" Lizard Poisons Spock ");
            Console.WriteLine(" Spock Smashes Scissors ");
            Console.WriteLine(" Scissors Decapitates Lizard ");
            Console.WriteLine(" Lizard Eats Paper ");
            Console.WriteLine(" Paper Disproves Spock ");
            Console.WriteLine(" Spock Vaporizes Rock");
            Console.WriteLine(" I know, It's fuckin' stupid, sorry");
        }

        public int WinGame(int bestOf)
        {

        }


        public int WinRound(int)
        {
            
        }

        public void CreatePlayers(int players)
        {
            if (players == 1)
            {
                playerOne = new RealPlayer();
                playerTwo = new SimPlayer();
            }

            if (players == 2)
            {
                playerOne = new RealPlayer();
                playerTwo = new RealPlayer();
            }
        }

        public int RoundWinner(int p1Choice, int p2Choice)
        {
            switch (p1Choice)
            {
                case 1:
                    if (p2Choice == 1)
                    {
                        return 0;
                    }
                    if (p2Choice == 2 || p2Choice == 4)
                    {
                        return 1;
                    }
                    break;
                case 2:
                    if (p2Choice == 2)
                    {
                        return 0;
                    }
                    if (p2Choice == 3 || p2Choice == 4)
                    {
                        return 1;
                    }
                    break;
                case 3:
                    if (p2Choice == 3)
                    {
                        return 0;
                    }
                    if (p2Choice == 1 || p2Choice == 5)
                    {
                        return 1;
                    }
                    break;
                case 4:
                    if (p2Choice == 4)
                    {
                        return 0;
                    }
                    if (p2Choice == 3 || p2Choice == 5)
                    {
                        return 1;
                    }
                    break;
                case 5:
                    if (p2Choice == 5)
                    {
                        return 0;
                    }
                    if (p2Choice == 1 || p2Choice == 2)
                    {
                        return 2;
                    }
                    break;
                default:
                    return 2;
            }
            return 2;
        }
    }  

}
