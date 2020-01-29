using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class SqrtUsingNewtons
    {
        public static double Sqrt()
        {
            Console.WriteLine("enter a number to find square root");
            double c = Utility.DoubleInput();
            double epsilon = 1e-15;
            double t = c;
           Console.WriteLine( Math.Abs((t - c) / t));
           Console.WriteLine(epsilon * t);
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            Console.WriteLine(t);
            return t;
        }
}
}
