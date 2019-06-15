using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp12
{
    class Program
    {
        //the function generates a sequense of uniqe random numbers in a specified range.
        static void Main()
        {
            int smallestInRange = 10; //the smallest number in the range
            int biggestInRange = 30; //the biggest number in the range

            List<int> uniqeNums = UniqeRandomNumbersInRange(smallestInRange, biggestInRange);

            foreach (var s in uniqeNums) Console.WriteLine(s);
        }

        static List<int> UniqeRandomNumbersInRange(int smallest, int biggest)
        {
            smallest--;
            List<int> possibilities = new List<int>();
            for (int i = smallest; i <= biggest; i++) possibilities.Add(i);

            List<int> output = new List<int>();

            Random rnd = new Random();

            int rangeCount = biggest - smallest;

            for(int i = 0; i < rangeCount; i++)
            {
                int randomIndex = rnd.Next(0, possibilities.Count()-1)+1;
                output.Add(possibilities[randomIndex]);
                possibilities.Remove(possibilities[randomIndex]);
            }

            return output;
        }





    }
}
