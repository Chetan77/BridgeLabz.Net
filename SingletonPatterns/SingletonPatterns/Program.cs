using System;
using System.Threading.Tasks;

namespace SingletonPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=> PrintLionDetails(),
                () => PrintElephentDetails(),
                ()=>PrintTigerdetails()
                );
        }

        private static void PrintElephentDetails()
        {
            Singlton elephent = Singlton.GetObject;
            elephent.Print("from lion");
        }

        private static void PrintLionDetails()
        {
            Singlton lion = Singlton.GetObject;
            lion.Print("from animal");
        }
        private static void PrintTigerdetails()
        {
            Singlton tiger = Singlton.GetObject;
            tiger.Print("from tiger");
        }
    }
}
