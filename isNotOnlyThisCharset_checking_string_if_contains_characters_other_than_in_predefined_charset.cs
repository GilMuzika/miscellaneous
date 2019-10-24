using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Homework_Module2_Programming_withCSarp7_17._10._19
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();

            if (isNotOnlyThisCharset(str)) throw new Exception($"The string {str} contains some symbols other than English lower case letters!");
            else Console.WriteLine(str);


        }

        //the function checks if a string contains some characters other than those in predefined charset
        static bool isNotOnlyThisCharset(string str)
        {
            char[] charset = "qwertyuioplkjhgfdsazxcvbnm".ToCharArray();
            char[] strChars = str.ToCharArray();
            bool flag = false;
            List<bool> lst = new List<bool>();

            foreach (var letter in strChars)
            {
                bool flag2 = false;
                foreach (var cchar in charset)
                {
                    if (letter == cchar) flag2 = true;

                }
                lst.Add(flag2);
            }

            if (lst.Contains(false)) flag = true;

            return flag;
        }














    }
}
