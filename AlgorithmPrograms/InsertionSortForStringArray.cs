using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace AlgorithmPrograms
{
    class InsertionSortForStringArray
    {
        public static String[] SortStringArray()
        {
            String[] arr = Utility.StringArrayInput();
            String temp = "";
            String[] array = new String[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i].ToLower();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) > 0)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("sorted array is");
            foreach(String s in array)
            {
            Console.WriteLine(s);
            }
            return array;
        }
    }
}
