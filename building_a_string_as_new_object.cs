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
           string sstr = new string('a', 1000);
           Console.WriteLine(sstr);
        }
    }
}