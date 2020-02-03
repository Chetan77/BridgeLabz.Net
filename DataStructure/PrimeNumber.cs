using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructure
{
    class PrimeNumber
    {
        public static void Prime()
        {
            Console.WriteLine("enter the range to find prime numbers");
            int n = Utility.IntInput();
            ArrayFunction(n);
            /*String numbers = null;
            int incr = 100;
            for (int i =0 ; i < 10; i++)
            {
             numbers = FindPrimeNumbers(incr);
                incr += 100;
            }
            Console.WriteLine(numbers);
            string[] s = numbers.Split(',');
            int[] arr = new int[s.Length - 1];
            //int[] primeNums = Array.ConvertAll(s, int.Parse).ToArray();
            for (int i = 0; i < s.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(s[i]);
            }
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count++;
                //Console.Write(arr[i]);
            }
            int size = (int)Math.Sqrt(count) + 1;
            Console.WriteLine(size);
            Console.WriteLine(count);
            Array2D(size, arr, count);*/
        }
        internal static int[,] ArrayFunction(int range)
        {
            int iterate = range / 100;
            int incr = 100;
            int prev = 0;
            int[,] arr2D = new int[iterate, 30];
            for (int i = 0; i < iterate; i++)
            {
            string[] s = FindPrimeNumbers(prev,incr).Split(',');
                prev = incr;
                incr += 100;
                int[] arr = new int[s.Length - 1];
                for (int k = 0; k < s.Length - 1; k++)
                {
                    arr[k] = Convert.ToInt32(s[k]);
                }
                for(int j = 0; j < arr.Length; j++)
                {
                    if (j <= arr.Length)
                    {
                        arr2D[i, j] = arr[j];
                    }
                    else
                    {
                        arr2D[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < iterate; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine();
            }
            return arr2D;
        }
        internal static void Array2D(int size, int[] ar, int count)
        {

            int[,] arr2D = new int[size, size];
            int a = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (a < count)
                    {
                        // Console.WriteLine(a);
                        arr2D[i, j] = ar[a];
                        a++;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr2D[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public static String FindPrimeNumbers(int min,int n)
        {
            String nums = "";
            for (int i = min; i <= n; i++)
            {
                int count = 0;
                for (int j = i; j >= 1; j--)
                {
                    if (i % j == 0)
                    {
                        count += 1;
                    }
                }
                if (count == 2)
                {
                    nums = nums + i + ",";
                }
            }
            return nums;
        }
    }
}
