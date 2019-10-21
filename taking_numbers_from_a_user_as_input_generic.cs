using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace Homework_Module2_Programming_withCSarp7_17._10._19
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] arrayOfNumbers = (float[])PleaseEnterSomeNumbers<float>(5).Clone();
            

            
            

            // Function 'PleaseEnterSomeNumbers()' gets one parameter [numeric_type number] that defines 
            // how much times a user will be asked for a number and returns an integer array of those numbers,
            // therefore the function treated as array when called.
            // Cloning needed because each attempt to address an element in the array that
            // the function represents cause executing the function 
            // which need a user interaction. 
            // By cloning the array we can address the function only once.

            //the function is generic and can take as a parameter number of any NUMERIC data type

            Console.WriteLine("--------------------------\n");
            
            foreach (var n in arrayOfNumbers)
            { Console.WriteLine(n); }
            Console.WriteLine("--------------------------\n");
        }





        static T[] PleaseEnterSomeNumbers<T>(T iterations)
        {
            bool flag = false;

            switch(Type.GetTypeCode(iterations.GetType()))
            {
                case TypeCode.Byte:
                    flag = true;
                    break;
                case TypeCode.SByte:
                    flag = true;
                    break;
                case TypeCode.UInt16:
                    flag = true;
                    break;
                case TypeCode.UInt32:
                    flag = true;
                    break;
                case TypeCode.UInt64:
                    flag = true;
                    break;
                case TypeCode.Int16:
                    flag = true;
                    break;
                case TypeCode.Int32:
                    flag = true;
                    break;
                case TypeCode.Int64:
                    flag = true;
                    break;
                case TypeCode.Decimal:
                    flag = true;
                    break;
                case TypeCode.Double:
                    flag = true;
                    break;
                case TypeCode.Single:
                    flag = true;
                    break;
                default:
                    flag = false;
                    break;

            }
            if(flag == false)
            {
                Console.WriteLine($"\nThe data type that used for this generic method ({iterations.GetType()}) is incorrect.");
                Console.WriteLine("Please use only NUMERIC data types");
                return default;
            }


            if (iterations.Equals(1)) { Console.WriteLine("Please enter one number:\n"); }
            else { Console.WriteLine("Please enter {0} numbers:\n", iterations); }

            T[] arriterations = new T[Convert.ToInt32(iterations)];

            for (int i = 0; i < Convert.ToInt32(iterations); i++)
            {
                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        // Cast ConvertFromString(string text) : object to (T)
                        arriterations[i] = (T)converter.ConvertFromString(Console.ReadLine());
                    }
                    else i--;
                }
                catch(Exception ex)
                {
                    i--;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\n This is not a number! \nPlease enter only numbers. \nNow lets try again: \n");
                }
            }
            return arriterations;
        }



    }
}
