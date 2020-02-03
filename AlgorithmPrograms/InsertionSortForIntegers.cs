using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSortForIntegers
    {
        public static int[] sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }
        public static void GetArray()
        {
            Console.WriteLine("enter array of elements size");
            int n = Utility.IntInput();
            int[] arr = new int[n];
            Console.WriteLine("enetr array of elements ");
            for(int i = 0; i < arr.Length; i++)
            {

            }
        }
    }
}
