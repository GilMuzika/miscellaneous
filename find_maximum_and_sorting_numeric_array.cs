using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Homework_Module2_Programming_withCSarp7_17._10._19
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the length of two arrays to be created:");
            int[] lengthOfTheArray = (int[])PleaseEnterSomeNumbers(2).Clone();
            int[] array1 = new int[lengthOfTheArray[0]];
            int[] array2 = new int[lengthOfTheArray[1]];

            Random rnd = new Random();

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 100);
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = rnd.Next(0, 100);
            }
            Console.WriteLine();
            Console.WriteLine("the first array:");
            foreach (var s in array1) Console.Write(s + " ");
            Console.WriteLine();
            Console.WriteLine("The second array:");
            foreach (var s in array2) Console.Write(s + " ");
            Console.WriteLine("\n---------------------------\n");

            //-----------------------------------------

            int[] joinedArray = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                joinedArray[i] = array1[i];
            }
            for (int i = array1.Length; i < joinedArray.Length; i++)
            {
                joinedArray[i] = array2[i - array1.Length];
            }

            int[] resultArray = sorting(joinedArray, true);

            Console.WriteLine("The result array is:");
            foreach (var s in resultArray.Reverse()) Console.WriteLine(s);


        }

        static private int[] sorting(int[] array, bool trimDuplicates)
        {
            List<int> sorted = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int max = findMax(array);
                if (max > int.MinValue) sorted.Add(max);
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == max) 
                    { 
                        array[j] = int.MinValue; 
                        if(!trimDuplicates) break; 
                    }
                }

            }
            return sorted.ToArray();
        }

        static private int findMax(int[] array)
        {
            int max1 = array[0];
            int max2 = array[array.Length - 1];
            int max = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i + 1] > max1) max1 = array[i + 1];

            }
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i - 1] > max2) max2 = array[i - 1];

            }

            if (max1 > max2) max = max1; else max = max2;

            return max;
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
