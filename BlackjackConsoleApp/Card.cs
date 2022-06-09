using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackConsoleApp
{
    class Card
    {
        //Store Value in Array
        string[] cardNum = new string[2];
        public int[] cardTotal = new int[10];
        int counter = 0;



        //Practice the use of ENUM
        //ENUM


        public enum DeckValue 
        { 
           
           Two = 2,
           Three = 3,
           Four = 4,
           Five = 5,
           Six = 6,
           Seven = 7,
           Eight = 8,
           Nine = 9,
           Ten = 10,
           Ace = 11,
           Jack = 12,
           Queen = 13,
           King = 14
        
        }

        public enum Suit
        { 
            Hearts = 1,
            Spades = 2,
            Clubs = 3,
            Diamonds = 4
        
        
        }

        //Get Random CardSuitValue
        public string CardSuitValue()
        {
            

            Random random = new Random();
            int randomInteger = random.Next(1, 5);
            Enum.TryParse(randomInteger.ToString(), out Suit cardSuitValue);
            cardNum[1] = cardSuitValue.ToString();
            //Console.WriteLine(cardSuitValue);

            return cardNum[1];
        }

        //Get Random DeckValue(CardValue)

        public string CardValue() 
        {
            //string cardValue;
            Random random = new Random();
            int randomInteger = random.Next(2, 14);
            Enum.TryParse(randomInteger.ToString(), out DeckValue cardValue);
            //Console.WriteLine(randomInteger);
            
            if (randomInteger >= 12)
            {
                randomInteger = 10;
            }

            cardNum[0] = cardValue.ToString();

            cardTotal[counter] = randomInteger;
            counter++;
            
      
            return cardNum[0]; 
            


        }

   
    }


}
