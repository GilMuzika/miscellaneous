using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp12
{
   public class Program
    {
        //the function generates a sequense of uniqe random numbers in a specified range.
        //the range includes the smallest and the biggest numbers themself at its extreme edges.
        public void Main()
        {
            int smallestInRange = 10; //the smallest number in the range
            int biggestInRange = 30; //the biggest number in the range

            string uniqeNums = UniqeRandomString(smallestInRange, biggestInRange);

             Console.Write(uniqeNums);
        }

        static string UniqeRandomString(int smallest, int biggest)
        {
            smallest--;
            List<int> possibilities = new List<int>();
            for (int i = smallest; i <= biggest; i++) possibilities.Add(i);

            string output = string.Empty;

            Random rnd = new Random();

            int rangeCount = biggest - smallest;

            for(int i = 0; i < rangeCount; i++)
            {
                int randomIndex = rnd.Next(0, possibilities.Count()-1)+1;
                output += possibilities[randomIndex];
                possibilities.Remove(possibilities[randomIndex]);
            }
            return output;
        }

	   
    }
}
