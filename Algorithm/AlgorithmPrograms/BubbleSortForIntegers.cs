using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSortForIntegers
    {
        public static int[] BubbleSort()
        {
            int[] arr = Utility.IntegerArrayElements();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int ar in arr)
            {
                Console.WriteLine(ar);
            }
            return arr;
        }
    }
}
