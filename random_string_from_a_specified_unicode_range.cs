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
           
           // this function returns a random string of a 
           // length specified by an integer argument that consists 
           // of chars from a specified range (Unicode sequence)
           string neededstring = RandomStringFromSpecifiedRange(14);
           Console.WriteLine(neededstring);
        }
        
        private static string RandomStringFromSpecifiedRange(int n)
            {
            Random rnd = new Random();
            int range = (int)'z' - (int)'a';
            int rnJustNum = rnd.Next(range);
            int i = 0;
            char[] charArr = new char[n];
            while (i < n)
                {
                    rnJustNum = rnd.Next(range);
                    int rnCharNum = rnd.Next((int)'a', (int)'z');
                    charArr[i] = (char)rnCharNum;
                    i++;
                }
                
            return new string(charArr);
            
            }
    }
}