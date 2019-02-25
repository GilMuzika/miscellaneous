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
           Console.WriteLine((int)'ָ');
           
           for (int i = (int)'א'; i <= (int)'ת'; i++) {
               Console.Write((char)i);
           }
           Console.WriteLine("\n\n");
           
           for(int i=33; i <= 65535; i++) {
           Console.Write(" "+i+"<=>"+(char)i+" ");
           }
           
           Console.ReadLine();
        }
    }
}