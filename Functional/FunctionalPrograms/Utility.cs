using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Utility
    {
        public static String StringInput() {

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
        public static int[] ArrayElements(int n)
        {
            int[] a = new int[n];
            Console.WriteLine("enter elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = Utility.IntInput();
            }
            return a;
        }
    }
}
