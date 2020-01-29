using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class ToBinary
    {
        public static string ConvertToBinary()
        {
            String s = "";
            Console.WriteLine("enter a number to find the binary");
            int n = Utility.IntInput();
            while (n > 0)
            {
                int rem = n % 2;
                n = n / 2;
                s = rem + s;
            }
            //Console.WriteLine(s);
            while (s.Length % 4 != 0)
            {
                s = 0 + s;
            }
            //Console.WriteLine(s);
            //int[] bin= StringToIntArray(s);
             return s; 
        }
        public static int[] StringToIntArray(String bin)
        {
            char[] ch=bin.ToCharArray();
            int[] binary = new int[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                binary[i] = ch[i]-48;
            }
            Utility.showArr(binary);
            return binary;
        }
        
    }
}
