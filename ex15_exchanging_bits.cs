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
           int num = 60;
           int position1 = 3;
           int position2 = 4;
           int position3 = 5;
           
           int changePosition1 = 24;
           int changePosition2 = 25;
           int changePosition3 = 26;
           
           
           /* for (int i = 0; i < 3; i++) 
               {
                   num = ChangingPosition ()
               } */
            
            
            int numChanged = ChangingPosition(num, position1, changePosition1);
           
            Console.WriteLine("\n| "+numChanged+" | ");
            
            numChanged = ChangingPosition(numChanged, position2, changePosition2);
           
            Console.WriteLine("\n| "+numChanged+" | ");
            
            numChanged = ChangingPosition(numChanged, position3, changePosition3);
           
            Console.WriteLine("\n| "+numChanged+" | ");
            
        }
        
        
        private static int ChangingPosition(int num, int position1, int changePosition1)
            {
                // int changedNum = num;
                
                if (CheckPosition(num, position1) && CheckPosition(num, changePosition1)) 
               {
                  // no changes needed, the bit in two positions is alreadyvthe same (both 1)
                  Console.WriteLine($"No changes needed, the bits on both positions {position1} and {changePosition1} already are 1");
               }
                if (CheckPosition(num, position1) && !CheckPosition(num, changePosition1)) 
               {
                  // we need to change the bit to 0
                  Console.WriteLine($"We need to change the bit on position {position1} from 1 to 0");
                  /*
                  נקודה חשובה!
                  כדי להפוך 1 ל 0 בפוזיציה של הביט 1
                  במספר השני שבו יש רק ביט 1 אחד והשאר הם אפסים,
                  אנו משתמשים כאן באופרטור הבינארי 
                  XOR [1^1=0;0^0=0;1^0=1;0^1=1]
                  הוא יחזיר 0 בפוזיציה של 1 במספר השני (מספר הייחוס) רק כאשר
                  בפוזיציה המקבילה במספר שעובדים עליו יהיה 1
                  (ה-1 היחיד של מספר הייחוס יתקל ב-1 במספר שעובדים עליו
                  אם ה-1 שבמספר הייחוס יתקל ב-0 במספר הנגדי היא יהפוך אותו לאחד!
                  יש לוודא בהתניות שהפוזיציה הנדרשת במספר שעובדים עליו
                  היא 1 !!!
                  */
                  
                  num =  (num ^ (1 << position1)); Console.WriteLine($"{num}");
               }
                if (!CheckPosition(num, position1) && CheckPosition(num, changePosition1)) 
               {
                  // we need to change the bit to 1
                  Console.WriteLine($"We need to change the bit on position {position1} from 0 to 1");
                  
                  num =  (num | (1 << position1)); Console.WriteLine($"{num}");
                  
               }
                if (!CheckPosition(num, position1) && !CheckPosition(num, changePosition1)) 
               {
                  // no changes needed, the bit in two positions is alreadyvthe same (both 0)
                  Console.WriteLine($"No changes needed, the bits on both positions {position1} and {changePosition1} already are 0");
               }   
               
               return num;
            }
        
        
        
        // if 'flag' that the fylunction returns is true
        // sovthe bit in 'n' on position 'pos' is 1
        // elswere is 0
        private static Boolean CheckPosition(int n, int position)
            { bool flag;
                if ((n & (1 << position)) != 0) flag = true;
                else flag = false;
                return flag;
            }
            
    }
}