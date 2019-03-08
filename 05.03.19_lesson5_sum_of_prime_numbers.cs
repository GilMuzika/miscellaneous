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
           
           
           
           
        
        // this row not needed, we need only one number on each calling of the function
        //int[] arrayOfNumbers = (int[])PleaseEnterSomeNumbers(1).Clone();
            
            
            
            int sum = 0;
            int n;
            do
            {
                n = PleaseEnterSomeNumbers(1)[0];
                sum = sum + n;
            }

            while (PrimeNumCalc( n ));

            Console.WriteLine(sum);









        }



        static bool PrimeNumCalc(int n)
        {
            int j = n - 1;
            while (j > 1)
            {
                if (n % j == 0) { return false; }
                j = j - 1;
            }
            return true;
        }

        static int[] PleaseEnterSomeNumbers(int iterations)
        {

            if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            int[] arriterations = new int[iterations];

            for (int i = 0; i < iterations; i++)
            {
                //if (i > 0) { Console.Clear(); }
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