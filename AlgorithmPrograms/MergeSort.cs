using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSort
    {
        public static void Merge(int[] arr, int begin, int mid, int end)
        {

            int left = mid - begin + 1;
            int right = end - mid;
            int i, j;

            int[] LeftArray = new int[left];
            int[] RightArray = new int[right];

            for (i = 0; i < left; ++i)
                LeftArray[i] = arr[begin + i];

            for (j = 0; j < right; ++j)
                RightArray[j] = arr[mid + 1 + j];


            i = 0; j = 0;
            int k = begin;
            while (i < left && j < right)
            {
                if (LeftArray[i] <= RightArray[j])
                {
                    arr[k] = LeftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = RightArray[j];
                    j++;
                }
                k++;
            }
            while (i < left)
            {
                arr[k] = LeftArray[i];
                i++;
                k++;
            }

            while (j < right)
            {
                arr[k] = RightArray[j];
                j++;
                k++;
            }
        }

        public static void Sort(int[] arr, int beg, int end)
        {
            if (beg < end)
            {
                int mid = (beg + end) / 2;
                Sort(arr, beg, mid);
                Sort(arr, mid + 1, end);
                Merge(arr, beg, mid, end);
            }
        }
        public static void ArrayElements()
        {
            int[] arr = Utility.IntegerArrayElements();
            Sort(arr, 0, arr.Length-1);

            Console.WriteLine("\nSorted array");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
                Console.WriteLine();
            }
        }
    }
}
