using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class PalindromeUsingDequeue
    {
        public static void Palindrome()
        {
            Console.WriteLine("eneter a string");
            string word = Utility.StringInput();
            char[] chars = word.ToCharArray();
            bool b = CheckPalindrome(chars);
            if (b)
            {
                Console.WriteLine(word+" is a palindrome");
            }
            else
            {
                Console.WriteLine(word+" is not palindrome");
            }
        }
        internal static Boolean CheckPalindrome(char[] chars)
        {
            DeQueue<char> deQueue = new DeQueue<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                deQueue.AddRear(chars[i]);
            }
            deQueue.PrintDeQueue();
            int j = 0;
            while(j < chars.Length)
            {
                char c=deQueue.RemoveRear();
                if (chars[j] != c)
                {
                    return false; 
                }
                Console.WriteLine(chars[j]);
                j++;
            }
            return deQueue.IsEmpty();
        }
    }
}
