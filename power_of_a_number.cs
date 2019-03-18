using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
           decimal[] numberAndPower = (decimal[])PleaseEnterSomeNumbers(2).Clone();
           
           decimal number = numberAndPower[0];
           decimal power = numberAndPower[1];
           
           decimal numberInPower = Power(number, power);
           
           Console.WriteLine(numberInPower);
        }
        
        
        
        static decimal Power(decimal x, decimal n)
        {
            decimal firstX = x;
            for(int i = 2; i <= n; i++)
            {
                x=x*firstX;
            }
            
            return x;
        }
        
        
        
        
        
        
        static decimal[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            decimal[] arriterations = new decimal[iterations];

            for (int i = 0; i < iterations; i++)
            {
                if (i > 0) { Console.Clear(); }
                if (i != 0) { Console.WriteLine("Please enter a number: \n"); }
                decimal line;
            EnterNumber:
                if (Decimal.TryParse(Console.ReadLine(), out line)) { arriterations.SetValue(line, i); }
                else { Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n"); goto EnterNumber; }
                //Console.Clear();
            }

            return arriterations;
        }
    }
}