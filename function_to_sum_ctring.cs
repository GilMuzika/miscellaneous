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
           string ln = Console.ReadLine();
           
           Console.ForegroundColor = ConsoleColor.Red;
           Console.BackgroundColor = ConsoleColor.White;
           ConsoleColor[] colrs = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
           
           Console.WriteLine(SumAllCodesOfString(ln));
           foreach (var clr in colrs) {Console.BackgroundColor = clr; Console.WriteLine(clr.GetType());}
           
           Console.WriteLine(typeof(ConsoleColor));
           
        }
        
        static double SumAllCodesOfString (string ln)
        {
            char[] arrln = ln.ToCharArray();
            
            double sum = 0.0d;
            foreach (char onechar in arrln) {
                int oneint = 0;
                if (Int32.TryParse(onechar.ToString(), out oneint)) {sum=sum+Convert.ToDouble(oneint); /*Console.WriteLine(Convert.ToDouble(oneint)+" | "+sum);*/}
                else {sum=sum+Convert.ToDouble((int)onechar); /*Console.WriteLine(Convert.ToDouble((int)onechar)+" | "+sum);*/}
               // Console.WriteLine(sum);
            }
            
            return sum;
        }
    }
}