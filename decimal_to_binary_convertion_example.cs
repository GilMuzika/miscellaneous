/*
C# Sharp Exercises: Decimal to Binary

https://www.w3resource.com/csharp-exercises/data-types/csharp-data-type-exercise-11.php
*/

using System;

public class Exercise11
{
  public static void Main()
  {   
    string answer;  
    string result; 
  
         Console.Write("Input a Number : ");
        answer = Console.ReadLine();
         
            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
   }
   