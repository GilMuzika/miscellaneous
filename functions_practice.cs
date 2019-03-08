using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        static void Main(string[] args)
        {
        int number = 20;
        AddFive(number);
        Console.WriteLine(number);
        AddFiveWithRef(ref number);
        Console.WriteLine(number);
        //Console.WriteLine(AddFive(number));
        Console.WriteLine(AddFiveWithReturn(number));
        //Console.ReadKey();
        }

        static void AddFive(int number)
        {
        number = number + 5;
        //return number;
        }
           
        
           
        static int AddFiveWithReturn (int number)
        {
        number = number + 5;
        return number;
        } 
        
        static void AddFiveWithRef (ref int number)
        {
        number = number + 5;
            
        }

    }    
}