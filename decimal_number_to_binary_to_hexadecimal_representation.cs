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
           List<int> multi3 = new List<int>();
           for (int i = 20; i <= 40; i++)
           {
               if (i % 3 == 0) multi3.Add(i);
           }
           
           
           
        foreach (int n in multi3)  Console.Write($"Decimal: {n}, Binary: {ToBinary(n)}, Hexadecimal: {BinaryToHex(ToBinary(n))}\n");
        
        Console.WriteLine();
           
           
        Console.WriteLine("\n------------------\n");   
        
        //string binNum = ToBinary(2135498);
        //Console.WriteLine(BinaryToHex(binNum));
           
        
         
          
        
           
         
         
         
         
           
       // Console.WriteLine(binNum);
        }
        
        
        //converting binary to hexadecimal
        static string BinaryToHex(string binary)
        {
        
            
            if(binary.Count() % 4 != 0)
            {
                int padNum = (binary.Count() - binary.Count() % 4) + 4;
                binary = binary.PadLeft(padNum, '0');
            }
        string[] partBin = new string[] {"0000","0001","0010","0011","0100","0101","0110","0111","1000","1001","1010","1011","1100","1101","1110","1111"};
        string[] partHex = new string[] {"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F"};
            
        string[,] partBinHex = new string[2,16];    
        
        
            for (int i = 0; i < partBinHex.GetLength(1); i++)
            {
                partBinHex[0, i] = partBin[i];
            }
            for (int i = 0; i < partBinHex.GetLength(1); i++)
            {
                partBinHex[1, i] = partHex[i];
            }
            
            
        string[] binaryQuartered = new string[binary.Length/4];
        for (int i = 0, j = 0; i < binaryQuartered.Length; i++, j += 4)
        {
                binaryQuartered[i] = binary.Substring(j, 4);
        }
            
         
        string[] hexa = new string[binaryQuartered.Length];
            for(int i = 0; i < binaryQuartered.Length; i++)
            {
                for (int j = 0; j < partBinHex.Length/2; j++)
                {
                    if (binaryQuartered[i] == partBinHex[0,j]) hexa[i] = partBinHex[1,j];
                }
            }
            
           return String.Join("", hexa);
           
            
        }
        
        
        
        
        
        //converting to binary
        static string ToBinary(int num)
        {
        string result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            
        if(result.Count() % 4 != 0)
        {
            int padNum = (result.Count() - result.Count() % 4) + 4;
            result = result.PadLeft(padNum, '0');
        }
            
        return result;
        }
        
        

    }
}
