using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagramsInRreverseOrder
    {
        public static void PrimeAnagramsStack()
        {
            Stackmpl<int> stack = new Stackmpl<int>();
            /*string s=Utility.FindPrimeNumbers(1000);
            Console.WriteLine(s);
            int[] ar = Utility.PrimeIntArray(s);
            for(int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
            }*/
            int[] arr=Utility.PrimeIntArray(Utility.FindPrimeNumbers(1000));
            Console.WriteLine(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j=i+1;j<arr.Length; j++)
                {
                    if (Utility.Anagram(arr[i], arr[j])){
                        stack.Push(arr[i]);
                    }
                }
            }
           // Console.WriteLine("printing");
            while (!stack.isEmpty())
            {
                //int n=stack.Pop();
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
