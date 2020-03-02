using System;

namespace SingletonStaticInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 15;
            Console.WriteLine( StaticInit.Add(a,b));
            Console.WriteLine( StaticInit.Substract(StaticInit.Add(a, b), b));
        }
    }
}
