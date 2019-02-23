using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Example of function that gets an undefines number of parameters.
 */ 

namespace Fundamentals_of_computer_programming_with_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here the function EnterNumbersf() called and in this specific case it gets a 3 parameters of a type string,
            // but it able to take any amaunt of parameters
            EnterNumbersf(2.ToString(), 3.ToString(), 5.ToString());
        }

        //the function EnterNumbersf() take an amount of parameters [type string] as an array, 
        //internally it create a new array of integers, converts each value of a string array 'strnumbers' to integer
        //and add it  to an integer array 'numbers' one by one. 
        //finally it returns the array 'numbers' as a whole.
        static int[] EnterNumbersf(params string[] strnumbers)
        {
            int[] numbers = new int[strnumbers.Length];
            int i = 0;
            foreach (string num in strnumbers) { numbers[i] = Convert.ToInt32(num); i++; Console.WriteLine(num+" | "+num.GetType());  }
            return numbers;
        }
    }   
}
