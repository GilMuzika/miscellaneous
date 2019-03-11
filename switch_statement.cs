using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           
        int num = PleaseEnterSomeNumbers(1)[0];
        
            switch(num)
            {
                case 0:
                Console.WriteLine("zero");
                break;
                
                case 1:
                Console.WriteLine("one");
                break;
                
                case 2:
                Console.WriteLine("two");
                break;
                
                case 3:
                Console.WriteLine("three");
                break;
                
                case 4:
                Console.WriteLine("four");
                break;
                
                case 5:
                Console.WriteLine("five");
                break;
                
                case 6:
                Console.WriteLine("sex");
                break;
                
                case 7:
                Console.WriteLine("seven");
                break;
                
                case 8:
                Console.WriteLine("eight");
                break;
                
                case 9:
                Console.WriteLine("nine");
                break;
                
                default:
                Console.WriteLine("Don't match!");
                break;
            }
           
           
        }
        
        
    

        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
                if (i > 0) { Console.Clear(); }
                if (i != 0) { Console.WriteLine("Please enter a number: \n"); }
                int line;
            EnterNumber:
                if (Int32.TryParse(Console.ReadLine(), out line)) { arriterations[i] = line; }
                else { Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n"); goto EnterNumber; }
                //Console.Clear();
            }

            return arriterations;
        }    
        
        
        
        
    }
    
}