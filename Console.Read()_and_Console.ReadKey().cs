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
           Console.WriteLine("Console.Read() and Console.ReadKey() \n");
           Console.WriteLine("\'Console.Read()\'' : \n");
           
                
               // int clr = Console.Read();
               for (int clr = Console.Read(); clr != 0;)
                   {
                      // int clr = Console.Read();
                       Console.WriteLine("{0} = {1}", (char)clr, clr);
                   }
        }
    }
}