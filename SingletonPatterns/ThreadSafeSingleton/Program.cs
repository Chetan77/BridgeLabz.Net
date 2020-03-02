using System;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=>PrintFirst(),
                ()=>PrintSecond()
                );
        }
        private static void PrintFirst()
        {
            Methods me = Methods.GetObject;
            Console.WriteLine("from first method");
        }
        private static void PrintSecond()
        {
            Methods me = Methods.GetObject;
            Console.WriteLine("from second method");
        }
    }
}
