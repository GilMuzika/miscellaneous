using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
/*
муха
комар
волк
медведь
лягушка
Муха-цокотуха, Комар-пискун, Мышка-норушка, Лягушка-квакушка, Волк-волчище.

*/
namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main(string[] args) 
        {
           
           string animalsstr = @"муха
комар
волк
медведь
лягушка";
           
           
           string[] animals = animalsstr.Split('\n');
           /*animals[0] ="Комар";
           animals[1] ="Заяц";
           animals[2] ="Муха";
           animals[3] ="Волк";
           animals[4] ="Медведь";*/
           
           for (int i = 0; i < animals.Length; i++)
               {
                   Console.WriteLine("Муха-цокотуха, Комар-пискун, Мышка-норушка, Лягушка-квакушка, Волк-волчище.".Contains(animals[i], StringComparison.OrdinalIgnoreCase));
                   Console.WriteLine(animals[i]);
               }
           
        }
   
   }
   
   
  

    public static class StringExtensions
    {
      public static bool Contains(this String str, String substring, 
                               StringComparison comp)
       {                            
          if (substring == null)
             throw new ArgumentNullException("substring", 
                                             "substring cannot be null.");
          else if (! Enum.IsDefined(typeof(StringComparison), comp))
             throw new ArgumentException("comp is not a member of StringComparison", "comp");

          return str.IndexOf(substring, comp) >= 0;                      
       }
    } 
   
}
