using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsoleApp
{
    class CardStatus
    {
        Card card = new Card();
        //Start the game, draw cards to both party
        string[] playersCardValue = new string[10];
        string[] playersCardSuitValue = new string[10];
        //string[] hostCardValue = new string[10];
        //string[] hostCardSuitValue = new string[10];


        public void drawPlayersCardValue() 
        {
            for (int i = 0; i < playersCardValue.Length; i++)
            {
                playersCardValue[i] = card.CardValue();
            }
        
        }

        public void drawPlayersCardSuit() 
        {
            for (int i = 0; i < playersCardSuitValue.Length; i++)
            {
                playersCardSuitValue[i] = card.CardSuitValue();
            }


        }

     


        //When the player cardStatus is burst
        public void burst() 
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Card has burst.....");
            Console.WriteLine("YOU LOSE");

        }
        //Ask player want to hit card or not
        public void askHit() 
        {
            Console.WriteLine("Do you want to hit a card ?");
            Console.WriteLine("Option 1: YES\nOption 2: NO");
            Console.WriteLine();

        }
        //Player win
        public void win()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYOU WIN!");
        }
        //Player tie with host
        public void tie() 
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nIt's a Tie!");

        }
        //Player lost
        public void lose()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nYOU LOSE");
        }
        //When the host card status is burst
        public void opponentBurst() 
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
        }


        


    }
}
