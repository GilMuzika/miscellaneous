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
         Console.WriteLine("Please write the text to be writen to a file\n \n \n ");
         string[] thetext = {""};
         
         
         
         while (thetext.Length <= 2) {
         thetext[thetext.Length-1] = Console.ReadLine();
         Array.Resize(ref thetext, thetext.Length+1);
         }
         Console.WriteLine(thetext.Length);
         
         
         
         
         
         
         File.WriteAllLines("homework_05.02.2019_question_4_message4.txt", thetext);
            
         
         
         
         
         
        }
    }
}