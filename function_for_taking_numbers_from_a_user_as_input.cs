using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Example of a function that provides a console user interface for taking a heeded amount of numbers from a user as input
 * and returns an array of those numbers
 */

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = (int[])PleaseEnterSomeNumbers(5).Clone();

            // Function 'PleaseEnterSomeNumbers()' gets one parameter [integer number] that defines 
            // how much times a user will be asked for a number and returns an integer array of those numbers,
            // therefore the function treated as array when called.
            // Cloning needed because each attempt to address an element in the array that
            // the function represents cause executing the function 
            // which need a user interaction. 
            // By cloning the array we can address the function only once.

            Console.WriteLine("--------------------------\n");

            foreach (int n in arrayOfNumbers)
                { Console.WriteLine(n); }
                Console.WriteLine("--------------------------\n");
            }


            static int[] PleaseEnterSomeNumbers(int iterations)
            {
                if (iterations == 1) { Console.WriteLine("Please enter one number:\n"); }
                else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

                int[] arriterations = new int[iterations];

                for (int i = 0; i < iterations; i++)
                {
                    if (Int32.TryParse(Console.ReadLine(), out int line)) arriterations[i] = line;
                    else { i--; Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n"); }
                }
                return arriterations;
            }


        
    }
}
