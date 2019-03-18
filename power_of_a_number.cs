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
        
        
        
        // this,function actually calculates power. It takes two parameters, 
        // the first is the number that it's power to be calculated, 
        // and the second is the power of the number.
        static decimal Power(decimal num, decimal pow)
        {
            decimal firstNum = num;
            for(int i = 2; i <= pow; i++)
            {
                num=num*firstNum;
            }
            
            return num;
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