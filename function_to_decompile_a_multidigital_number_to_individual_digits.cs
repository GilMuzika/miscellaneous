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
            int nstr = 345;


            int[] arrOfInts = (int[])DecompileAMultidigitNumberTOIndividualDigits(nstr).Clone();

            Console.WriteLine(arrOfInts[0]);
            Console.WriteLine(arrOfInts[1]);
            Console.WriteLine(arrOfInts[2]);
            

        }


        static int[] DecompileAMultidigitNumberTOIndividualDigits (int n)
        {
            List<int> listOfInts = new List<int>();
            while (n > 0)
            {
                listOfInts.Add(n % 10);
                n = n / 10;
                
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
           
        
    }
}