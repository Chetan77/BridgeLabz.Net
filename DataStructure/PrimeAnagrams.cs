using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PrimeAnagrams
    {
        public static void PrimeAnagram()
        {
            int x = 0, y = 0, sum = 100; ;
            Console.WriteLine("enetr the range");
            int n = Utility.IntInput();
            int[,] nArr = new int[10,30];
            int[] arr = Utility.PrimeIntArray(Utility.FindPrimeNumbers(n));
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    bool b = Utility.Anagram(arr[i], arr[j]);
                    if (b)
                    {
                        if (arr[i] >= sum)
                        {
                            sum += 100;
                            x++;
                            y = 0;
                        }
                        
                        nArr[x,y] = arr[i];
                        y++;
                    }
                    
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(nArr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
