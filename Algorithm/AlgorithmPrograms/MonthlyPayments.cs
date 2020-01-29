using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MonthlyPayments
    {
        public static double Payment()
        {
            Console.WriteLine("enter the principle amount");
            double p = Utility.DoubleInput();
            Console.WriteLine("enter the number of years you want");
            int y = Utility.IntInput();
            Console.WriteLine("enter the interest rate");
            float R = Utility.FloatInput();
            double n = 12 * y;
            double r = R / (12 * 100);
            double payment = p * r / ( 1- Math.Pow((1 + r), -n));
            Console.WriteLine("every month payment is" + payment);
            return payment;
        }
    }
}
