using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class SimpleBalancedParanthesis
    {
         static Stackmpl<char> stackmpl = new Stackmpl<char>();
        public static void BalancedParanthesis()
        {
            /*int i = 0;
            Console.WriteLine("eneter how charecters you want to add");
            int n = Utility.IntInput();
            while( i< n){
                Console.WriteLine("enter the charecters");
                stackmpl.Push(Utility.CharInput());
                i++;
            }
            stackmpl.PrintStack();
            char c=stackmpl.Pop();
            Console.WriteLine("poped element is" + c);
            Console.WriteLine(stackmpl.isEmpty());*/

            String s = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8))/(4+3)";
            bool scheck = CheckForBallance(s);
            if (scheck)
            {
                Console.WriteLine("paranthesis are balanced");
            }
            else
            {
                Console.WriteLine("paranthesis are not balanced");
            }
            
        }
        internal static Boolean CheckForBallance(String s)
        {
            char[] ch = s.ToCharArray();
            int count = 0;
            bool b = true;
            for (int j = 0; j < ch.Length; j++)
            {
                if (ch[j] == '(')
                {
                    stackmpl.Push(ch[j]);
                    count++;
                }
                else if (ch[j] == ')')
                {
                    if (count == 0)
                    {
                        return false;
                    }
                    char c = stackmpl.Pop();
                    count--;
                }
            }
            return stackmpl.isEmpty();
        }

    }
}
