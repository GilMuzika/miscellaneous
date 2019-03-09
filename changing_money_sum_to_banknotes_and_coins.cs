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
           int moneyNumber = PleaseEnterSomeNumbers(1)[0];
           
           int[][] changed = ChangingToBanknotes(moneyNumber);
           
           for (int i = 0; i < changed[0].Length || i < changed[1].Length; i++)
               {
                   Console.WriteLine(changed[0][i]+" : "+changed[1][i]);
               }
        }
        
        
        
        private static int[][] ChangingToBanknotes(int moneyFirst)
        {
            int note200 = moneyFirst / 200;
            int note200_remainder = moneyFirst % 200;
            
            int note100 = note200_remainder / 100;
            int note100_remainder = note200_remainder % 100;
            
            int note50 = note100_remainder / 50;
            int note50_remainder = note100_remainder % 50;
            
            int note10 = note50_remainder / 10;
            int note10_remainder = note50_remainder % 10;
            
            int note5 = note10_remainder / 5;
            int note5_remainder = note10_remainder % 5;
        
            
            int[][] notes = new int[2][];
            notes[0] = new int[6];
            notes[1] = new int[6];
            
            notes[0][0] = 200; notes[1][0] = note200;
            notes[0][1] = 100; notes[1][1] = note100;
            notes[0][2] = 50; notes[1][2] = note50;
            notes[0][3] = 10; notes[1][3] = note10;
            notes[0][4] = 5; notes[1][4] = note5;
            notes[0][5] = 1; notes[1][5] = note5_remainder;
            
            return notes;
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