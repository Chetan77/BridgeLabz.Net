using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataStructure
{
    class Utility
    {
        public static int IntInput()
        {
            int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("enter correct value");
            }
            return n;
        }
        public static string StringInput()
        {
            string s = null;
            try
            {
                s = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("enter correct value" + e.StackTrace);
            }
            return s;
        }
        public static char CharInput()
        {
            char c = Convert.ToChar(Console.ReadLine());
            return c;
        }
        public static String FindPrimeNumbers(int n)
        {
            Collection<int> coll = new Collection<int>();
            String nums = "";
            for (int i = 1; i <= n; i++)
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
                    coll.Add(i);
                    nums = nums  + i+",";
                }
            }
            return nums;
        }
        public static bool Anagram(int num1, int num2)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int count1 = 0;
            int count2 = 0;
            int c = 0;
            while (num1 != 0)
            {
                int n = num1 % 10;
                a[n]++;
                count1++;
                num1 /= 10;
            }

            while (num2 != 0)
            {
                int m = num2 % 10;
                b[m]++;
                count2++;
                num2 /= 10;
            }

            if (count1 != count2)
            {
                return false;
            }
            else
            {
                for (int k = 0; k < 10; k++)
                {
                    if (a[k] == b[k])
                    {
                        c++;
                    }
                }

                if (c == 10)
                {
                    return true;
                }
            }

            return false;
        }
        public static String FindPrimeNumbers(int min, int n)
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
        internal static int[] PrimeIntArray(String nums)
        {
            string[] s = nums.Split(",");
            int[] arr = new int[s.Length - 1];

            for (int k = 0; k < s.Length - 1; k++)
            {
                arr[k] = Convert.ToInt32(s[k]);
            }
            Console.WriteLine("");
            return arr;
        }
    }
}
