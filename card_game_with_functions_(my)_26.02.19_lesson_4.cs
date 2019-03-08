using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace CSharp_Shell
{

    public static class Program 
    {
        static void Main(string[] args)
        {
            
            CardGame(5);
            
        }
        
            
        static void CardGame(int maxScore)
        {
            Random engine = new Random();

            int compscore = 0;
            int myscore = 0;
            int rounds =1;

            while (compscore != maxScore && myscore != maxScore)
            {
                
              Console.WriteLine($"Round numbers: {rounds++}; \nMy score: {myscore}; \ncomputer score: {compscore}\n");  
              
                // get new card
                int rndmycard = engine.Next(2, 15);
               // get new card
                int rndcomputercard = engine.Next(2, 15);
        

                PrintWhoWon(BodyOfTheGame(rndmycard), BodyOfTheGame(rndcomputercard), ref myscore, ref compscore);
                Console.WriteLine("----------------\n");
            }

        } 
        



        static void PrintWhoWon(int mycard, int computercard, ref int myscore, ref int compscore)
        {
            if (mycard > computercard)
            {
                myscore++; Console.WriteLine($"I won this round!!!! My score is {myscore}");
            }
            else if (computercard > mycard)
            {
                compscore++; Console.WriteLine($"Computer won ... booooo. Computer's score is {compscore}");
            }
            else
            {
                Console.WriteLine("Tie!");
            }


        }


        static int BodyOfTheGame(int card)
        {

            // print card

            switch (card)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine(card); 
                    break;
                case 11:
                    Console.WriteLine("J"); 
                    break;
                case 12:
                    Console.WriteLine("Q"); 
                    break;
                case 13:
                    Console.WriteLine("K"); 
                    break;
                case 14:
                    Console.WriteLine("A"); 
                    break;
                default:
                    Console.WriteLine("Bad card!!!!!!!!!!!"); 
                    break;
            }
            
            Thread.Sleep(500);
            return card;

        }
    }
}