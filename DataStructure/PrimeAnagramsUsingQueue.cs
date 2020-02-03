using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagramsUsingQueue
    {
        public static void PrintPrimeInQueue()
        {
            QueueImpl<int> queue = new QueueImpl<int>();
            Console.WriteLine("enter the range to print anagrams in queue");
            int n=Utility.IntInput();
            int[] arr= Utility.PrimeIntArray(Utility.FindPrimeNumbers(n));
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(Utility.Anagram(arr[i], arr[j]))
                    {
                        queue.EnQueue(arr[i]);
                    }
                }
            }
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.DeQueue());
            }
        }
    }
}
