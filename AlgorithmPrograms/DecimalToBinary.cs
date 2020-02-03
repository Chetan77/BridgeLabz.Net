using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class DecimalToBinary
    {
        public static int Binary()
        {
            String s=ToBinary.ConvertToBinary();
            int[] bin=ToBinary.StringToIntArray(s);
            int[] SArr=SwapNibbles(bin);
            int number = ToDecimal(SArr);
            Console.WriteLine(number);
            //Console.WriteLine("power of 2"+ PowerOf2(number));
            Boolean b = PowerOf2(number);
            if (b)
            {
                Console.WriteLine("the number is power of 2");
            }
            else
            {
                Console.WriteLine("the number is not power of 2");
            }
            return number;
        }
        public static Boolean PowerOf2(int n)
        {
            Console.WriteLine("in");
            int i = 0;
            int temp = 0;
            while (temp < n)
            {
                temp = (int)Math.Pow(2, i);
                if (temp == n)
                {
                    return true;
                }
                i++;
            }
            
            return false;
        }

        static int[] SwapNibbles(int[] arr)
        {
            int temp, j = arr.Length - 4;
            for (int i = 0; i < 4; i++)
            { 
                temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j++;
            }
            return arr;
        }
        static int ToDecimal(int[] binary)
        {
            int dec = 0, j = 0;
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == 1)
                {
                    dec = dec + (int)Math.Pow(2, j);
                }
                j++;
            }
            Console.WriteLine("After swapping the decimal number is " + dec);
            return dec;
        }
    }
}
