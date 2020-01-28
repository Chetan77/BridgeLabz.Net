using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PrimeFactors
    {
        public static void PrimeFactoirs()
        {
            Console.WriteLine("enter the max number to find orime factors");
            int n = Utility.IntInput();
                while (n % 2 == 0)
                {
                    Console.Write(2 + " ");
                    n /= 2;
                }
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    while (n % i == 0)
                    {
                        Console.Write(i + " ");
                        n /= i;
                    }
                }
                if (n > 2)
                    Console.Write(n);
            }
        }
}
