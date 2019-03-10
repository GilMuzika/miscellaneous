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
           
           
           int[][] changed = DividingToGroups(moneyNumber, 200, 100, 50, 20, 10, 5);
           
           for (int i = 0; i < changed[0].Length || i < changed[1].Length; i++)
               {
                   Console.WriteLine(changed[0][i]+" : "+changed[1][i]);
               }
        }
        
        
        // This function divides an amount (number) to some pre-defined groups (numbers),
        // and calculates the best suitable amount of each group 
        // to fit the amount for dividing (there may be a reminder that don't fit any group).
        // The first parameter that the function gets is the amount to be divided, 
        // and all the other parameters are the pre-definitions of the dividing groups.
        // It returns a two-arrayed jagged array that it's first array consist of 
        // thr pre-definitions of the groups,for division (actually the parameters that the function gets from the second)
        // and the second array actually consists from the amounts of each group that needed to fit the amount to be divided.
        // The values in the jagged array coming correspondively.
        private static int[][] DividingToGroups(int amountFirst, params int[] groupsForChanging)
        {
            int[] group = new int[groupsForChanging.Length+1];
            
            
            group[0] = amountFirst / groupsForChanging[0];
            int group_remainder = amountFirst % groupsForChanging[0];
            
            for (int i = 1; i < groupsForChanging.Length; i++)
                {
                group[i] = group_remainder / groupsForChanging[i];
                group_remainder = group_remainder % groupsForChanging[i];
                }
            group[group.Length-1] = group_remainder;

            
            int[][] groups = new int[2][];
            groups[0] = new int[group.Length];
            groups[1] = new int[group.Length];
            
            for (int i = 0; i < group.Length; i++)
                {
                    if (i < groupsForChanging.Length) groups[0][i] = groupsForChanging[i]; 
                    else groups[0][i] = 1;
                    
                    groups[1][i] = group[i];
                }
            
            
            return groups;
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