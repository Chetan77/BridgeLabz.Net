using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class QuadraticRoots
    {
        public static void roots()
        {
            Console.WriteLine("enter the value of a");
            double a = Utility.DoubleInput();
            Console.WriteLine("enter the value of b");
            double b = Utility.DoubleInput();
            Console.WriteLine("enter the value of c");
            double c = Utility.DoubleInput();
            double delta = b * b - 4 * a * c;
            double root1 = -b + Math.Sqrt(delta) / 2 * a;
            double root2 = -b - Math.Sqrt(delta) / 2 * a;
            Console.WriteLine("root1 =" + root1);
            Console.WriteLine("root2 =" + root2);
        }
    }
}
