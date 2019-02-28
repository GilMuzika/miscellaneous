// https://www.dotnetperls.com/jagged-array
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
           string[] hebrewNumbers = new string[11];
           hebrewNumbers[0] = "אפס";
           hebrewNumbers[1] = "אחד";
           hebrewNumbers[2] = "שתים";
           hebrewNumbers[3] = "שלוש";
           hebrewNumbers[4] = "ארבע";
           hebrewNumbers[5] = "חמש";
           hebrewNumbers[6] = "שש";
           hebrewNumbers[7] = "שבע";
           hebrewNumbers[8] = "שמונה";
           hebrewNumbers[9] = "תשע";
           hebrewNumbers[10] = "עשר";
           
           
           string[] englishNumbers = new string[11];
           englishNumbers[0] = "Zero";
           englishNumbers[1] = "One";
           englishNumbers[2] = "Two";
           englishNumbers[3] = "Three";
           englishNumbers[4] = "Four";
           englishNumbers[5] = "Five";
           englishNumbers[6] = "Six";
           englishNumbers[7] = "Seven";
           englishNumbers[8] = "Eight";
           englishNumbers[9] = "Nine";
           englishNumbers[10] = "Ten";
           
           
           string[][] mlngNames = new string[2][]; //declaring a nrw jagged array of 2 arrays
           
           
            mlngNames[0] = new string[hebrewNumbers.Length]; //declaring a new array that is a first of the jagged array
            for (int i = 0; i < hebrewNumbers.Length; i++)   
                {
                    mlngNames[0][i] = hebrewNumbers[i];
                }
           
            mlngNames[1] = new string[englishNumbers.Length]; //declaring a new array that is a second of the jagged array
            for (int i = 0; i < englishNumbers.Length; i++)
                {
                    mlngNames[1][i] = englishNumbers[i];
                }
           
           
           
           for (int i = 0; i < mlngNames.Length; i++) 
               {
                   // Console.WriteLine("a");
                   for (int j = 0; j < englishNumbers.Length || j < hebrewNumbers.Length; j++)
                       {
                           Console.WriteLine(mlngNames[i][j]);
                       }
               }
           Console.WriteLine("\n-------------------\n");
           for(int i =0; i < mlngNames[0].Length || i < mlngNames[1].Length; i++) 
               {
                   Console.WriteLine(mlngNames[0][i]+" <=> "+mlngNames[1][i]);
               }
           
        }
    }
}