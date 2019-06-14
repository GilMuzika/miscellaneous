using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = EnterPositiveNumber();
            Console.WriteLine("\n-------------------\n" + n);

        }

        static int EnterPositiveNumber()
        {
            Console.WriteLine("Please enter one positive number:");
            int num = 0;
            bool tprsp = false;
            do
            {
                tprsp = Int32.TryParse(Console.ReadLine(), out num);
                if (tprsp)
                {
                    if (num >= 0) { Console.WriteLine("Your number is " + num); }
                    else { Console.WriteLine("The number {0} is negative! \nYou must enter only positive numbers or zero! \nTry again.", num); tprsp = false; }
                }
                else Console.WriteLine("Sorry, this isn't a number, try again!");


            }
            while (!tprsp);
            return num;

        }

    }
}
