using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class StringAnagram
    {
        public static Boolean Anagram(String str1,String str2)
        {
            if(str1.Length != str2.Length)
            {
                return false;
            }
            if (!str1.Equals(str2))
            {
                return false;
            }
            return true;
        }
        public static void CheckAnagram()
        {
            String s1 = Utility.StringInput();
            String s2 = Utility.StringInput();
            String str1 = Utility.SortCharsInArray(s1);
            String str2 = Utility.SortCharsInArray(s2);
            Boolean b = Anagram(str1, str2);
            if (b)
            {
                Console.WriteLine("two strings are anagrams");
            }
            else
            {
                Console.WriteLine("two strings are not anagrams");

            }
        }
    }
}
