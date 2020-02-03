using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class hashingFunctionToSearch
    {
        public static void Test()
        {
            HashImpl<int> hashImpl = new HashImpl<int>();
            Console.WriteLine("enter how meny numbers you want to add in" +
                "the hash");
            int n = Utility.IntInput();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter" + i + "number");
                hashImpl.Insert(Utility.IntInput());
                Console.WriteLine("added");
            }
            Console.WriteLine("numbers are");
            hashImpl.PrintHash();
            Console.WriteLine("enter a number to search or add");
            int num = Utility.IntInput();
            if (hashImpl.Search(num))
            {
            hashImpl.Remove(10);
                Console.WriteLine("removed");
            }
            else
            {
                hashImpl.Insert(num);
                Console.WriteLine("added");
            }
            hashImpl.PrintHash();
        }
    }
}
