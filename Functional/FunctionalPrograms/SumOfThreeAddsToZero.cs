using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class SumOfThreeAddsToZero
    {
        public static void SumOfThree()
        {
            Console.WriteLine("enetr the size of elements");
            int n = Utility.IntInput();
            int[] arr=Utility.ArrayElements(n);
            for(int i = 0; i < arr.Length-3; i++)
            {
                for(int j = i + 1; j < arr.Length - 2; j++)
                {
                    for(int k = i + 2; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine("Sum Of Three numbers adds to zero are " + arr[i] +
                                ", " + arr[j] + "and " + arr[k]);
                        }
                    }
                }
            }
        }
    }
}
