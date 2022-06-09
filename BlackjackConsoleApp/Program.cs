using System;

namespace BlackjackConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //Set App Variable
            
            string appName = "BlackJack";
            string appVer = "1.0";
            string appAuthor = "Gan Sheer Win";
            string appCreationDate = "31st May 2022";

            //Change Text Colour

            Console.ForegroundColor = ConsoleColor.Blue;

            //Write Out Application Information

            Console.WriteLine("Hello World!");
            Console.WriteLine("{0} Version {1} by {2}\nCreate on {3}", appName, appVer, appAuthor, appCreationDate);
           
            //Reset Text Colour to Yellow for Title
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            

            //Start Game Prompt Out

            Console.WriteLine("\nPress ENTER key to Start Game...");
            Console.ReadLine();
            Console.Beep();

            //Clear Console
            Console.Clear();

            //Ask the Username
            Console.WriteLine("Please enter your username...");
            string username = Console.ReadLine();
           
            //Validate Username(If User didn't Enter Anything)
            while (string.IsNullOrWhiteSpace(username))
            {
                Console.Beep();
                Console.WriteLine("Username can't be empty, please try again...\nPlease enter your username...");
                username = Console.ReadLine();
            }
            

            //Clear Console
            Console.Clear();
            //Welcome Message
            Console.Beep();
            Console.WriteLine("Hello {0} , Welcome to Blackjack! Enjoy your Game!", username);


            //Declaring Boolean Variable
            bool quit = false;
            bool isPlaying = true;
            
            //Give user the option to quit the game
            Console.WriteLine("Press ENTER to continue or Enter QUIT if you want to quit the game.");
            string option =  Console.ReadLine();

            if (option == "QUIT" || option == "quit" || option == "Quit")
            {
                quit = true;
                Console.WriteLine("Thanks for playing...See you next time...");
            }
            else
            {
                Console.WriteLine("Loading...");
                Console.WriteLine("The game is starting soon...");
                Console.ReadLine();
                
            }

            //Testing call method from another class
            do
            {
                //Store cardvalue into variable
                Card card = new Card(); //Call card function from Card class;
                CardStatus cardStatus = new CardStatus(); //Call card status function from CardStatus class;

                

                //Player CardValue
                string card1 = card.CardValue();
                string card2 = card.CardValue();
                string card3 = card.CardValue();
                string card4 = card.CardValue();
                string card5 = card.CardValue();

                //Host cardValue
                string card6 = card.CardValue();
                string card7 = card.CardValue();
                string card8 = card.CardValue();
                string card9 = card.CardValue();
                string card10 = card.CardValue();



                //Store cardSuitValue into variable
                //Player CardSuit
                string cardSuit1 = card.CardSuitValue();
                string cardSuit2 = card.CardSuitValue();
                string cardSuit3 = card.CardSuitValue();
                string cardSuit4 = card.CardSuitValue();
                string cardSuit5 = card.CardSuitValue();


                //Host cardSuit
                string cardSuit6 = card.CardSuitValue();
                string cardSuit7 = card.CardSuitValue();
                string cardSuit8 = card.CardSuitValue();
                string cardSuit9 = card.CardSuitValue();
                string cardSuit10 = card.CardSuitValue();


                //Player Total Card
                //Total value of current status of card of Player
                int totalTwoCard = card.cardTotal[0] + card.cardTotal[1];
                int totalThreeCard = card.cardTotal[0] + card.cardTotal[1] + card.cardTotal[2];
                int totalFourCard = card.cardTotal[0] + card.cardTotal[1] + card.cardTotal[2] + card.cardTotal[3];
                int totalFiveCard = card.cardTotal[0] + card.cardTotal[1] + card.cardTotal[2] + card.cardTotal[3] + card.cardTotal[4];

                //Host totalofCard
                //Total value of current status of card of Player
                int hostTotalTwoCard = card.cardTotal[5] + card.cardTotal[6];
                int hostTotalThreeCard = card.cardTotal[5] + card.cardTotal[6] + card.cardTotal[7];
                int hostTotalFourCard = card.cardTotal[5] + card.cardTotal[6] + card.cardTotal[7] + card.cardTotal[8];
                int hostTotalFiveCard = card.cardTotal[5] + card.cardTotal[6] + card.cardTotal[7] + card.cardTotal[8] + card.cardTotal[9];

                //Declare Ace Special Attribute for player
                //When there are 2 A
                //2 card condition
                if ((card1 == "Ace" && card2 == "Ace")) //if the opening is two ace
                {
                    totalTwoCard = totalTwoCard - 1;

                }
                //3 card condition
                else if ((card1 == "Ace" && card3 == "Ace") || (card2 == "Ace" && card3 == "Ace")) //Check if there's 3 card
                {
                    totalThreeCard = totalThreeCard - 20;
                    totalFourCard = totalFourCard - 20;
                    totalFiveCard = totalFiveCard - 20;
                }

                //4 card condition
                else if ((card1 == "Ace" && card4 == "Ace") || (card2 == "Ace" && card4 == "Ace") || (card3 == "Ace" && card4 == "Ace"))
                {
                   
                    totalFourCard = totalFourCard - 20;
                    totalFiveCard = totalFiveCard - 20;
                }
                //5 card condition
                else if ((card1 == "Ace" && card5 == "Ace") || (card2 == "Ace" && card5 == "Ace") || (card3 == "Ace" && card5 == "Ace") || (card4 == "Ace" && card5 == "Ace"))
                {
                    
                    
                    totalFiveCard = totalFiveCard - 20;
                }


                //When they are 3A
                //4 card condition
                else if ((card2 == "Ace" && card3 == "Ace" && card4 == "Ace") || (card1 == "Ace" && card3 == "Ace" && card4 == "Ace"))
                {
                    totalFourCard = totalFourCard - 30;

                }

                //5 card condistion
                else if ((card3 == "Ace" && card4 == "Ace" && card5 == "Ace") || (card2 == "Ace" && card3 == "Ace" && card5 == "Ace") || (card1 == "Ace" && card3 == "Ace" && card5 == "Ace"))
                {
                    totalFiveCard = totalFiveCard - 30;
                }

                //When there are 4A
                // 5 card condition
                else if ((card2 == "Ace" && card3 == "Ace" && card4 == "Ace" && card5 == "Ace") || (card1 == "Ace" && card3 == "Ace" && card4 == "Ace" && card5 == "Ace"))
                {
                    totalFiveCard = totalFiveCard - 40;
                }

                //When there is only 1A
                else if ((card1 == "Ace") || (card2 == "Ace") || (card3 == "Ace") ) //if you have 3 card but only 1 of them is Ace
                {

                    totalThreeCard = totalThreeCard - 10;
                    totalFourCard = totalFourCard - 10;
                    totalFiveCard = totalFiveCard - 10;
                    
                }
                else if (card4 == "Ace")
                {
                    totalFourCard = totalFourCard - 10;
                    totalFiveCard = totalFiveCard -  10;
                }
                else if (card5 =="Ace")
                {
                    totalFiveCard = totalFiveCard - 10;
                }


                //Declare Ace Special Attribute for host
                //When there are 2 A
                //2 card condition
                if (card6 == "Ace" && card7 == "Ace") //if the opening is two ace
                {
                    hostTotalTwoCard = hostTotalTwoCard - 1;

                }

                //3 card condition
                else if ((card6 == "Ace" && card8 == "Ace") || (card6 == "Ace" && card9 == "Ace")) //Check if there's 3 card
                {
                    hostTotalThreeCard = hostTotalThreeCard - 20;
                }

                //4 card condition
                else if ((card6 == "Ace" && card9 == "Ace") || (card7 == "Ace" && card9 == "Ace") || (card8 == "Ace" && card9 == "Ace"))
                {
                    
                    hostTotalFourCard = hostTotalFourCard - 20;
                }
                //5 card condition
                else if ((card6 == "Ace" && card10 == "Ace") || (card7 == "Ace" && card10 == "Ace") || (card8 == "Ace" && card10 == "Ace") || (card9 == "Ace" && card10 == "Ace"))
                {
              
                    hostTotalFiveCard = hostTotalFiveCard - 20;
                }


                //When they are 3A
                //4 card condition
                else if ((card7 == "Ace" && card8 == "Ace" && card9 == "Ace") || (card6 == "Ace" && card8 == "Ace" && card9 == "Ace"))
                {
                    hostTotalFourCard = hostTotalFourCard - 30;

                }

                //5 card condistion
                else if ((card8 == "Ace" && card9 == "Ace" && card10 == "Ace") || (card7 == "Ace" && card9 == "Ace" && card10 == "Ace") || (card6 == "Ace" && card9 == "Ace" && card10 == "Ace"))
                {
                    hostTotalFiveCard = hostTotalFiveCard - 30;
                }

                //When there are 4A
                // 5 card condition
                else if ((card7 == "Ace" && card8 == "Ace" && card9 == "Ace" && card10 == "Ace") || (card6 == "Ace" && card8 == "Ace" && card9 == "Ace" && card10 == "Ace"))
                {
                    hostTotalFiveCard = hostTotalFiveCard - 40;
                }

                //When there is only 1A
                else if ((card6 == "Ace") || (card7 == "Ace") || (card8 == "Ace") ) //if you have 3 card but only 1 of them is Ace
                {

                    hostTotalThreeCard = hostTotalThreeCard - 10;
                    hostTotalFourCard = hostTotalFourCard - 10;
                    hostTotalFiveCard = hostTotalFiveCard - 10;
                    
                    
                }

                else if (card9 == "Ace")
                {
                    hostTotalFourCard = hostTotalFourCard - 10;
                    hostTotalFiveCard = hostTotalFiveCard - 10;
                }

                else if (card10 == "Ace")
                {
                    hostTotalFiveCard = hostTotalFiveCard - 10;
                }




                //Start the game
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Your Cards");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Card 1: {0} {1}", card1, cardSuit1);//Ace Heart card1
                Console.WriteLine("Card 2: {0} {1}", card2, cardSuit2);//King Spades card2
                Console.WriteLine("Total Card Value: {0}", totalTwoCard); //card1+card2
                Console.WriteLine("--------------------------------");
                
                cardStatus.askHit();

                //Check whether the user want to hit card or not

                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    if (choice == 1) //If the player choose to hit a third card
                    {
                        Console.Clear();
                        Console.WriteLine("You hit a card.");
                        Console.WriteLine("The card value is {0} {1}", card3, cardSuit3); //Write out the new card value


                        //Write out current card status
                        Console.WriteLine("\nYour Cards");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Card 1: {0} {1}", card1, cardSuit1);//Ace Heart card1
                        Console.WriteLine("Card 2: {0} {1}", card2, cardSuit2);//King Spades card2
                        Console.WriteLine("Card 3: {0} {1}", card3, cardSuit3);
                        Console.WriteLine("Total Card Value: {0}", totalThreeCard); //card1+card2
                        Console.WriteLine("--------------------------------");


                        //Check whether the cardstatus is burst or not
                        if (totalThreeCard > 21)
                        {
                            //Console.BackgroundColor = ConsoleColor.Red;
                            //Console.ForegroundColor = ConsoleColor.White;
                            //Console.WriteLine("Card has burst.....");
                            //Console.WriteLine("YOU LOSE");
                            cardStatus.burst();
                            isPlaying = false;
                        }
                        //Ask the user want to hit card or not
                        else
                        {
                            //Console.WriteLine("Do you want to hit a card ?");
                            //Console.WriteLine("Option 1: YES\nOption 2: NO");
                            //Console.WriteLine();
                            cardStatus.askHit();

                            //If the user want to hit a fourth card
                            try
                            {
                                int choice1 = Int32.Parse(Console.ReadLine());

                                if (choice1 == 1) //The player has hit the fourth card 
                                {
                                    Console.Clear();
                                    Console.WriteLine("You hit a card.");
                                    Console.WriteLine("The card value is {0} {1}", card4, cardSuit4); //Write out the new card value


                                    //Write out current card status
                                    Console.WriteLine("\nYour Cards");
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Card 1: {0} {1}", card1, cardSuit1);//Ace Heart card1
                                    Console.WriteLine("Card 2: {0} {1}", card2, cardSuit2);//King Spades card2
                                    Console.WriteLine("Card 3: {0} {1}", card3, cardSuit3);
                                    Console.WriteLine("Card 4: {0} {1}", card4, cardSuit4);
                                    Console.WriteLine("Total Card Value: {0}", totalFourCard); //card1+card2+card3+card4
                                    Console.WriteLine("--------------------------------");

                                    //Check whether the fourth card is burst or not
                                    if (totalFourCard > 21)
                                    {
                                        //Console.BackgroundColor = ConsoleColor.Red;
                                        //Console.ForegroundColor = ConsoleColor.White;
                                        //Console.WriteLine("Card has burst.....");
                                        //Console.WriteLine("YOU LOSE");
                                        cardStatus.burst();
                                        isPlaying = false;
                                    }
                                    //Ask the user want to hit a fifth card or not 
                                    else
                                    {
                                        //Console.WriteLine("Do you want to hit a card ?");
                                        //Console.WriteLine("Option 1: YES\nOption 2: NO");
                                        //Console.WriteLine();
                                        cardStatus.askHit();

                                        //Ask If the user want to hit a fifth card
                                        try
                                        {
                                            int choice2 = Int32.Parse(Console.ReadLine());

                                            if (choice2 == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("You hit a card.");
                                                Console.WriteLine("The card value is {0} {1}", card5, cardSuit5); //Write out the new card value


                                                //Write out current card status
                                                Console.WriteLine("\nYour Cards");
                                                Console.WriteLine("--------------------------------");
                                                Console.WriteLine("Card 1: {0} {1}", card1, cardSuit1);//Ace Heart card1
                                                Console.WriteLine("Card 2: {0} {1}", card2, cardSuit2);//King Spades card2
                                                Console.WriteLine("Card 3: {0} {1}", card3, cardSuit3);
                                                Console.WriteLine("Card 4: {0} {1}", card4, cardSuit4);
                                                Console.WriteLine("Card 5: {0} {1}", card5, cardSuit5);
                                                Console.WriteLine("Total Card Value: {0}", totalFiveCard); //card1+card2+card3+card4+card5
                                                Console.WriteLine("--------------------------------");

                                                //Check whether the fifth card is burst or not
                                                if (totalFiveCard > 21)
                                                {
                                                    //Console.BackgroundColor = ConsoleColor.Red;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("Card has burst.....");
                                                    //Console.WriteLine("YOU LOSE");
                                                    cardStatus.burst();
                                                    isPlaying = false;


                                                }
                                                else
                                                {
                                                    //Console.BackgroundColor = ConsoleColor.Green;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("\nYOU WIN!"); //If the total value not burst
                                                    cardStatus.win();
                                                    isPlaying = false;
                                                }



                                            }

                                            else if (choice2 == 2)
                                            {
                                                //Compare with the host

                                                Console.ForegroundColor = ConsoleColor.DarkMagenta;


                                                //Host will hit a card if his total card value less than 16
                                                if (hostTotalTwoCard <= 16)
                                                {
                                                    Console.WriteLine("\nYour opponent has hit a third card.");

                                                    if (hostTotalThreeCard <= 16)
                                                    {
                                                        Console.WriteLine("\nYour opponent has hit a fourth card.");

                                                        if (hostTotalFourCard <= 16)
                                                        {
                                                            Console.WriteLine("\nYour opponent has hit a fifth card.");

                                                            if (hostTotalFiveCard < 21)
                                                            {

                                                                Console.WriteLine("\nYour opponent cards");
                                                                Console.WriteLine("--------------------------------");
                                                                Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                                Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                                Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                                Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                                Console.WriteLine("Card 5: {0} {1}", card10, cardSuit10);
                                                                Console.WriteLine("Total Card Value: {0}", hostTotalFiveCard); //card6+card7

                                                                //Console.BackgroundColor = ConsoleColor.Red;
                                                                //Console.ForegroundColor = ConsoleColor.White;
                                                                //Console.WriteLine("\nYOU LOST");
                                                                cardStatus.lose();
                                                                isPlaying = false;
                                                            }
                                                            else
                                                            {

                                                                Console.WriteLine("\nYour opponent cards");
                                                                Console.WriteLine("--------------------------------");
                                                                Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                                Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                                Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                                Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                                Console.WriteLine("Card 5: {0} {1}", card10, cardSuit10);
                                                                Console.WriteLine("Total Card Value: {0}", hostTotalFiveCard); //card6+card7

                                                                //Console.BackgroundColor = ConsoleColor.Green;
                                                                //Console.ForegroundColor = ConsoleColor.White;
                                                                //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                                                cardStatus.opponentBurst();
                                                                isPlaying = false;
                                                            }
                                                        }

                                                        else if (hostTotalFourCard >= 17 && hostTotalFourCard <= 21)
                                                        {
                                                            Console.WriteLine("\nYour opponent cards");
                                                            Console.WriteLine("--------------------------------");
                                                            Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                            Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                            Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                            Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                            Console.WriteLine("Total Card Value: {0}", hostTotalFourCard); //card6+card7

                                                            //Compare value between the player and host
                                                            //Check whether you win or not
                                                            if (totalFourCard > hostTotalFourCard)
                                                            {

                                                                //Console.BackgroundColor = ConsoleColor.Green;
                                                                //Console.ForegroundColor = ConsoleColor.White;
                                                                //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                                                cardStatus.win();
                                                                isPlaying = false;

                                                            }
                                                            else if (totalFourCard == hostTotalFourCard)
                                                            {
                                                                //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                                //Console.ForegroundColor = ConsoleColor.White;
                                                                //Console.WriteLine("\nIt's a Tie!");
                                                                cardStatus.tie();
                                                                isPlaying = false;
                                                            }
                                                            else
                                                            {
                                                                //Console.BackgroundColor = ConsoleColor.Red;
                                                                //Console.ForegroundColor = ConsoleColor.White;
                                                                //Console.WriteLine("\nYOU LOSE");
                                                                cardStatus.lose();
                                                                isPlaying = false;
                                                            }


                                                        }

                                                        else if (hostTotalFourCard > 21)
                                                        {

                                                            Console.WriteLine("\nYour opponent cards");
                                                            Console.WriteLine("--------------------------------");
                                                            Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                            Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                            Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                            Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                            Console.WriteLine("Total Card Value: {0}", hostTotalFourCard); //card6+card7

                                                            //Console.BackgroundColor = ConsoleColor.Green;
                                                            //Console.ForegroundColor = ConsoleColor.White;
                                                            //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                                            cardStatus.opponentBurst();
                                                            isPlaying = false;
                                                        }
                                                    }


                                                    else if (hostTotalThreeCard >= 17 && hostTotalThreeCard <= 21)
                                                    {
                                                        Console.WriteLine("\nYour opponent cards");
                                                        Console.WriteLine("--------------------------------");
                                                        Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                        Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                        Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                        Console.WriteLine("Total Card Value: {0}", hostTotalThreeCard); //card6+card7

                                                        //Compare value between the player and host
                                                        //Check whether you win or not
                                                        if (totalFourCard > hostTotalThreeCard)
                                                        {

                                                            //Console.BackgroundColor = ConsoleColor.Green;
                                                            //Console.ForegroundColor = ConsoleColor.White;
                                                            //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                                            cardStatus.win();
                                                            isPlaying = false;

                                                        }
                                                        else if (totalFourCard == hostTotalThreeCard)
                                                        {
                                                            //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                            //Console.ForegroundColor = ConsoleColor.White;
                                                            //Console.WriteLine("\nIt's a Tie!");
                                                            cardStatus.tie();
                                                            isPlaying = false;
                                                        }
                                                        else
                                                        {
                                                            //Console.BackgroundColor = ConsoleColor.Red;
                                                            //Console.ForegroundColor = ConsoleColor.White;
                                                            //Console.WriteLine("\nYOU LOSE");
                                                            cardStatus.lose();
                                                            isPlaying = false;
                                                        }


                                                    }

                                                    else if (hostTotalThreeCard > 21)
                                                    {

                                                        Console.WriteLine("\nYour opponent cards");
                                                        Console.WriteLine("--------------------------------");
                                                        Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                        Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                        Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                        Console.WriteLine("Total Card Value: {0}", hostTotalThreeCard); //card6+card7

                                                        //Console.BackgroundColor = ConsoleColor.Green;
                                                        //Console.ForegroundColor = ConsoleColor.White;
                                                        //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                                        cardStatus.opponentBurst();
                                                        isPlaying = false;
                                                    }



                                                }
                                                else
                                                {
                                                    Console.WriteLine("\nYour opponent cards");
                                                    Console.WriteLine("--------------------------------");
                                                    Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                    Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                    Console.WriteLine("Total Card Value: {0}", hostTotalTwoCard); //card6+card7


                                                    //Compare value between the player and host
                                                    //Check whether you win or not
                                                    if (totalFourCard > hostTotalTwoCard)
                                                    {

                                                        //Console.BackgroundColor = ConsoleColor.Green;
                                                        //Console.ForegroundColor = ConsoleColor.White;
                                                        //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                                        cardStatus.win();
                                                        isPlaying = false;

                                                    }
                                                    else if (totalFourCard == hostTotalTwoCard)
                                                    {
                                                        //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                        //Console.ForegroundColor = ConsoleColor.White;
                                                        //Console.WriteLine("\nIt's a Tie!");
                                                        cardStatus.tie();
                                                        isPlaying = false;
                                                    }
                                                    else
                                                    {
                                                        //Console.BackgroundColor = ConsoleColor.Red;
                                                        //Console.ForegroundColor = ConsoleColor.White;
                                                        //Console.WriteLine("\nYOU LOSE");
                                                        cardStatus.lose();
                                                        isPlaying = false;
                                                    }
                                                }
                                                //Ask again whether the player want to play again or not
                                                //Console.ResetColor();
                                                //Console.WriteLine("\nDo you want to play again?\nOption 1: YES\nOption2: NO");



                                            }






                                        }
                                        catch (Exception)
                                        {


                                        }

                                    }

                                }


                                else if (choice1 == 2) //If the player don't want to hit a card (3 cards on hand)
                                {
                                    //Compare with host 
                                    //Compare with the host

                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;


                                    //Host will hit a card if his total card value less than 16
                                    if (hostTotalTwoCard <= 16)
                                    {
                                        Console.WriteLine("\nYour opponent has hit a third card.");

                                        if (hostTotalThreeCard <= 16)
                                        {
                                            Console.WriteLine("\nYour opponent has hit a fourth card.");

                                            if (hostTotalFourCard <= 16)
                                            {
                                                Console.WriteLine("\nYour opponent has hit a fifth card.");

                                                if (hostTotalFiveCard < 21)
                                                {

                                                    Console.WriteLine("\nYour opponent cards");
                                                    Console.WriteLine("--------------------------------");
                                                    Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                    Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                    Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                    Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                    Console.WriteLine("Card 5: {0} {1}", card10, cardSuit10);
                                                    Console.WriteLine("Total Card Value: {0}", hostTotalFiveCard); //card6+card7

                                                    //Console.BackgroundColor = ConsoleColor.Red;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("\nYOU LOST");
                                                    cardStatus.lose();
                                                    isPlaying = false;
                                                }
                                                else
                                                {

                                                    Console.WriteLine("\nYour opponent cards");
                                                    Console.WriteLine("--------------------------------");
                                                    Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                    Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                    Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                    Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                    Console.WriteLine("Card 5: {0} {1}", card10, cardSuit10);
                                                    Console.WriteLine("Total Card Value: {0}", hostTotalFiveCard); //card6+card7

                                                    //Console.BackgroundColor = ConsoleColor.Green;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                                    cardStatus.opponentBurst();
                                                    isPlaying = false;
                                                }
                                            }

                                            else if (hostTotalFourCard >= 17 && hostTotalFourCard <= 21)
                                            {
                                                Console.WriteLine("\nYour opponent cards");
                                                Console.WriteLine("--------------------------------");
                                                Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                Console.WriteLine("Total Card Value: {0}", hostTotalFourCard); //card6+card7

                                                //Compare value between the player and host
                                                //Check whether you win or not
                                                if (totalThreeCard > hostTotalFourCard)
                                                {

                                                    //Console.BackgroundColor = ConsoleColor.Green;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                                    cardStatus.win();
                                                    isPlaying = false;

                                                }
                                                else if (totalThreeCard == hostTotalFourCard)
                                                {
                                                    //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("\nIt's a Tie!");
                                                    cardStatus.tie();
                                                    isPlaying = false;
                                                }
                                                else
                                                {
                                                    //Console.BackgroundColor = ConsoleColor.Red;
                                                    //Console.ForegroundColor = ConsoleColor.White;
                                                    //Console.WriteLine("\nYOU LOSE");
                                                    cardStatus.lose();
                                                    isPlaying = false;
                                                }


                                            }

                                            else if (hostTotalFourCard > 21)
                                            {

                                                Console.WriteLine("\nYour opponent cards");
                                                Console.WriteLine("--------------------------------");
                                                Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                                Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                                Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                                Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                                Console.WriteLine("Total Card Value: {0}", hostTotalFourCard); //card6+card7

                                                //Console.BackgroundColor = ConsoleColor.Green;
                                                //Console.ForegroundColor = ConsoleColor.White;
                                                //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                                cardStatus.opponentBurst();
                                                isPlaying = false;

                                            }
                                        }


                                        else if (hostTotalThreeCard >= 17 && hostTotalThreeCard <= 21)
                                        {
                                            Console.WriteLine("\nYour opponent cards");
                                            Console.WriteLine("--------------------------------");
                                            Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                            Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                            Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                            Console.WriteLine("Total Card Value: {0}", hostTotalThreeCard); //card6+card7

                                            //Compare value between the player and host
                                            //Check whether you win or not
                                            if (totalThreeCard > hostTotalThreeCard)
                                            {

                                                //Console.BackgroundColor = ConsoleColor.Green;
                                                //Console.ForegroundColor = ConsoleColor.White;
                                                //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                                cardStatus.win();
                                                isPlaying = false;

                                            }
                                            else if (totalThreeCard == hostTotalThreeCard)
                                            {
                                                //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                                //Console.ForegroundColor = ConsoleColor.White;
                                                //Console.WriteLine("\nIt's a Tie!");
                                                cardStatus.tie();
                                                isPlaying = false;
                                            }
                                            else
                                            {
                                                //Console.BackgroundColor = ConsoleColor.Red;
                                                //Console.ForegroundColor = ConsoleColor.White;
                                                //Console.WriteLine("\nYOU LOSE");
                                                cardStatus.lose();
                                                isPlaying = false;
                                            }


                                        }

                                        else if (hostTotalThreeCard > 21)
                                        {

                                            Console.WriteLine("\nYour opponent cards");
                                            Console.WriteLine("--------------------------------");
                                            Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                            Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                            Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                            Console.WriteLine("Total Card Value: {0}", hostTotalThreeCard); //card6+card7

                                            //Console.BackgroundColor = ConsoleColor.Green;
                                            //Console.ForegroundColor = ConsoleColor.White;
                                            //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                            cardStatus.opponentBurst();
                                            isPlaying = false;

                                        }



                                    }
                                    else
                                    {
                                        Console.WriteLine("\nYour opponent cards");
                                        Console.WriteLine("--------------------------------");
                                        Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                        Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                        Console.WriteLine("Total Card Value: {0}", hostTotalTwoCard); //card6+card7


                                        //Compare value between the player and host
                                        //Check whether you win or not
                                        if (totalThreeCard > hostTotalTwoCard)
                                        {

                                            //Console.BackgroundColor = ConsoleColor.Green;
                                            //Console.ForegroundColor = ConsoleColor.White;
                                            //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                            cardStatus.win();
                                            isPlaying = false;

                                        }
                                        else if (totalThreeCard == hostTotalTwoCard)
                                        {
                                            //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                            //Console.ForegroundColor = ConsoleColor.White;
                                            //Console.WriteLine("\nIt's a Tie!");
                                            cardStatus.tie();
                                            isPlaying = false;
                                        }
                                        else
                                        {
                                            //Console.BackgroundColor = ConsoleColor.Red;
                                            //Console.ForegroundColor = ConsoleColor.White;
                                            //Console.WriteLine("\nYOU LOSE");
                                            cardStatus.lose();
                                            isPlaying = false;
                                        }
                                    }




                                }
                                else
                                {
                                    //Ask the user again
                                    
                                }


                            }
                            catch (Exception)
                            {


                            }


                        }

                    }
                    else if (choice == 2)
                    {
                        //Compare with the host

                        Console.ForegroundColor = ConsoleColor.DarkMagenta;


                        //Host will hit a card if his total card value less than 16
                        if (hostTotalTwoCard <= 16)
                        {
                            Console.WriteLine("\nYour opponent has hit a third card.");

                            if (hostTotalThreeCard <= 16)
                            {
                                Console.WriteLine("\nYour opponent has hit a fourth card.");

                                if (hostTotalFourCard <= 16)
                                {
                                    Console.WriteLine("\nYour opponent has hit a fifth card.");

                                    if (hostTotalFiveCard < 21)
                                    {

                                        Console.WriteLine("\nYour opponent cards");
                                        Console.WriteLine("--------------------------------");
                                        Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                        Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                        Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                        Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                        Console.WriteLine("Card 5: {0} {1}", card10, cardSuit10);
                                        Console.WriteLine("Total Card Value: {0}", hostTotalFiveCard); //card6+card7

                                        //Console.BackgroundColor = ConsoleColor.Red;
                                        //Console.ForegroundColor = ConsoleColor.White;
                                        //Console.WriteLine("\nYOU LOST");
                                        cardStatus.lose();
                                        isPlaying = false;
                                    }
                                    else
                                    {

                                        Console.WriteLine("\nYour opponent cards");
                                        Console.WriteLine("--------------------------------");
                                        Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                        Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                        Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                        Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                        Console.WriteLine("Card 5: {0} {1}", card10, cardSuit10);
                                        Console.WriteLine("Total Card Value: {0}", hostTotalFiveCard); //card6+card7

                                        //Console.BackgroundColor = ConsoleColor.Green;
                                        //Console.ForegroundColor = ConsoleColor.White;
                                        //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                        cardStatus.opponentBurst();
                                        isPlaying = false;
                                    }
                                }

                                else if (hostTotalFourCard >= 17 && hostTotalFourCard <= 21)
                                {
                                    Console.WriteLine("\nYour opponent cards");
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                    Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                    Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                    Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                    Console.WriteLine("Total Card Value: {0}", hostTotalFourCard); //card6+card7

                                    //Compare value between the player and host
                                    //Check whether you win or not
                                    if (totalTwoCard > hostTotalFourCard)
                                    {

                                        //Console.BackgroundColor = ConsoleColor.Green;
                                        //Console.ForegroundColor = ConsoleColor.White;
                                        //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                        cardStatus.win();
                                        isPlaying = false;

                                    }
                                    else if (totalTwoCard == hostTotalFourCard)
                                    {
                                        //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                        //Console.ForegroundColor = ConsoleColor.White;
                                        //Console.WriteLine("\nIt's a Tie!");
                                        cardStatus.tie();
                                        isPlaying = false;
                                    }
                                    else
                                    {
                                        //Console.BackgroundColor = ConsoleColor.Red;
                                        //Console.ForegroundColor = ConsoleColor.White;
                                        //Console.WriteLine("\nYOU LOSE");
                                        cardStatus.lose();
                                        isPlaying = false;
                                    }


                                }

                                else if (hostTotalFourCard > 21)
                                {
                                    Console.WriteLine("\nYour opponent cards");
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                    Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                    Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                    Console.WriteLine("Card 4: {0} {1}", card9, cardSuit9);
                                    Console.WriteLine("Total Card Value: {0}", hostTotalFourCard); //card6+card7

                                    //Console.BackgroundColor = ConsoleColor.Green;
                                    //Console.ForegroundColor = ConsoleColor.White;
                                    //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                    cardStatus.opponentBurst();
                                    isPlaying = false;
                                }
                            }


                            else if (hostTotalThreeCard >= 17 && hostTotalThreeCard <= 21)
                            {
                                Console.WriteLine("\nYour opponent cards");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                Console.WriteLine("Total Card Value: {0}", hostTotalThreeCard); //card6+card7

                                //Compare value between the player and host
                                //Check whether you win or not
                                if (totalTwoCard > hostTotalThreeCard)
                                {

                                    //Console.BackgroundColor = ConsoleColor.Green;
                                    //Console.ForegroundColor = ConsoleColor.White;
                                    //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                    cardStatus.win();
                                    isPlaying = false;

                                }
                                else if (totalTwoCard == hostTotalThreeCard)
                                {
                                    //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    //Console.ForegroundColor = ConsoleColor.White;
                                    //Console.WriteLine("\nIt's a Tie!");
                                    cardStatus.tie();
                                    isPlaying = false;
                                }
                                else
                                {
                                    //Console.BackgroundColor = ConsoleColor.Red;
                                    //Console.ForegroundColor = ConsoleColor.White;
                                    //Console.WriteLine("\nYOU LOSE");
                                    cardStatus.lose();
                                    isPlaying = false;
                                }


                            }

                            else if (hostTotalThreeCard > 21)
                            {

                                Console.WriteLine("\nYour opponent cards");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                                Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                                Console.WriteLine("Card 3: {0} {1}", card8, cardSuit8);
                                Console.WriteLine("Total Card Value: {0}", hostTotalThreeCard); //card6+card7

                                //Console.BackgroundColor = ConsoleColor.Green;
                                //Console.ForegroundColor = ConsoleColor.White;
                                //Console.WriteLine("Congratulation! Your opponent has burst! You Won!");
                                cardStatus.opponentBurst();
                                isPlaying = false;
                            }



                        }
                        else
                        {
                            Console.WriteLine("\nYour opponent cards");
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Card 1: {0} {1}", card6, cardSuit6);//Ace Heart card6
                            Console.WriteLine("Card 2: {0} {1}", card7, cardSuit7);//King Spades card7
                            Console.WriteLine("Total Card Value: {0}", hostTotalTwoCard); //card6+card7


                            //Compare value between the player and host
                            //Check whether you win or not
                            if (totalTwoCard > hostTotalTwoCard)
                            {

                                //Console.BackgroundColor = ConsoleColor.Green;
                                //Console.ForegroundColor = ConsoleColor.White;
                                //Console.WriteLine("\nYOU WIN!"); //If the total value of the player is higher than the host
                                cardStatus.win();
                                isPlaying = false;

                            }
                            else if (totalTwoCard == hostTotalTwoCard)
                            {
                                //Console.BackgroundColor = ConsoleColor.DarkYellow;
                                //Console.ForegroundColor = ConsoleColor.White;
                                //Console.WriteLine("\nIt's a Tie!");
                                cardStatus.tie();
                                isPlaying = false;
                            }
                            else
                            {
                                //Console.BackgroundColor = ConsoleColor.Red;
                                //Console.ForegroundColor = ConsoleColor.White;
                                //Console.WriteLine("\nYOU LOSE");
                                cardStatus.lose();
                                isPlaying = false;
                            }
                        }





                    }
                    else
                    {

                        //Ask again the user whether want to hit card again or not


                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    Console.ResetColor();
                    Console.WriteLine("\nDo you want to play again?\nOption1: YES\nOption2: NO");

                    int playOption = Int32.Parse(Console.ReadLine());
                    if (playOption == 1)
                    {

                        isPlaying = true;

                    }
                    else if (playOption == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("THANK YOU {0}, WISH YOU HAVE A NICE DAY, SEE YOU NEXT TIME",username);
                    }
                }
                catch (Exception)
                {


                }

            } while (isPlaying);
 









        }


    }
}
