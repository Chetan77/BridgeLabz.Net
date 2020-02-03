using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BinarySearch
    {
        static int SearchBinary(String[] arr, String str)
        {
            int res = 0, length = arr.Length - 1;
            while (res <= length)
            {
                int m = res + (length - res) / 2;

                int result = str.CompareTo(arr[m]);
                if (result == 0)
                    return m;
                if (result > 0)
                    res = m + 1;
                else
                    length = m - 1;
            }

            return -1;
        }
        public static void Binary()
        {
            Console.WriteLine("eneter an element to find");
            String str = Utility.StringInput();
            String[] arr = { "abc", "chetan","choudhari","kishor","vitthal" };
            int result = SearchBinary(arr, str);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);
        }
    }
}
