using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
//
// finding minimal and maximal number in any 
// set of numbers without built-in functuons
//

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
        Random rndObj = new Random();
        
        int[] arrayOfNumbers = new int[100];
        for (int i = 0; i < 100; i++) 
            {
            arrayOfNumbers[i] = rndObj.Next(-100, 100);
            }
            
            
        // int[] arrayOfNumbers = (int[])PleaseEnterSomeNumbers(6).Clone();   
           
           // finding maximum value
           int max = arrayOfNumbers[0];
           int iMax;
           for (int i = 0; i < arrayOfNumbers.Length; i++)
               {
                   if (max < arrayOfNumbers[i]) 
                       {
                          max = arrayOfNumbers[i];
                          iMax = i;
                       }
               }       
                       
           
           // finding minimum value
           int min = arrayOfNumbers[arrayOfNumbers.Length-1];
           int iMin;
           for (int i = arrayOfNumbers.Length-1; i > 0; i--)
               {
                   if (min > arrayOfNumbers[i])
                       {
                           min = arrayOfNumbers[i];
                           iMin = i;
                       }
               
               }
            
            // sorting the elements in acsending order by iterative method
            int temp;
            for (int j = arrayOfNumbers.Length-1; j > 0; j--)
                {
                    for (int i = arrayOfNumbers.Length-1; i > 0; i--)
                        {
                            
                            if (arrayOfNumbers[i] > arrayOfNumbers[j])
                                {
                                    temp = arrayOfNumbers[i];
                                    arrayOfNumbers[i] = arrayOfNumbers[j];
                                    arrayOfNumbers[j] = temp;
                                }
                        }
                }
            
            
                
             //--------------------   
                
                foreach (int oneNum in arrayOfNumbers) {
                    Console.WriteLine(oneNum+" | ");
                    
                }
               
           
         Console.WriteLine("-----------\n\n"+max+"\n"+min); 
         
         
        }
    }
}