using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AlgorithmPrograms
{
    class Utility
    {
        public static String StringInput() {
            Console.WriteLine("enter a string");
            String s = Console.ReadLine();
            return s;
        }

        public static int IntInput() {
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static float FloatInput()
        {
            float f = float.Parse(Console.ReadLine());
            return f;
        }
        public static double DoubleInput()
        {
            double d = Convert.ToDouble(Console.ReadLine());
            return d;
        }
        public static long LongInput()
        {
            long l = long.Parse(Console.ReadLine());
            return l;
        }
        public static int[] IntegerArrayElements()
        {
            Console.WriteLine("enter size of integer array");
            int n = IntInput();
            int[] a = new int[n];
            Console.WriteLine("enter elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = Utility.IntInput();
            }
            return a;
        }
        public static void showArr(int[] arr)
        {
            // System.out.println("array is ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
        public static String[] StringArrayInput()
        {
            Console.WriteLine("enter the size of anarray");
            int n = IntInput();
            Console.WriteLine("enter the elements");
            String[] sArr = new String[n];  
            for(int i = 0; i < n; i++)
            {
                sArr[i] = StringInput();
            }
            return sArr;
        }
        public static String SortCharsInArray(String str)
        {
            String s = "";
            char[] c = str.ToCharArray();
            for(int i = 0; i < c.Length - 1; i++)
            {
                for(int j = 0; j < c.Length - i - 1; j++)
                {
                    if (c[j] > c[j + 1])
                    {
                        char t = c[j + 1];
                        c[j + 1] = c[j];
                        c[j] = t;
                    }
                }
            }
            for(int i = 0; i < c.Length; i++)
            {
                s = s+c[i];
            }
            return s;
        }
        static Collection<int> coll = new Collection<int>();
        public static Collection<int> PrimeNumberArray(int n)
        {
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
                }
            }
            return coll;
        }
        public static String FindPrimeNumbers(int n)
        {
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
                    nums = nums + " " + i;
                }
            }
            return nums;
        }
        public static String[] SplitStringOnSpace(String str)
        {
            String[] s = str.Split(" ");
            return s;
        }
        public static Boolean StringContains(String s1,String s2)
        {
            Boolean b = s1.Contains(s2);
            return b;
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
    }
}
