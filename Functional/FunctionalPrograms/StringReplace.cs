using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class StringReplace
    {
        public static String ReplaceString() {
            String s = "Hello <<UserName>>, How are you?";
            Console.WriteLine("enter the name which has to be replace");
            String name = Utility.StringInput();
            char[] c = name.ToCharArray();
            bool b = false;
            for(int i = 0; i < c.Length; i++)
            {
                if ((c[i] >= 65 && c[i] <= 90) || c[i] >= 97 && c[i]<= 122)
                {
                    b= true;
                }
            }
            if (b)
            {
                if (name.Length > 3)
                {
                    String a = s.Replace("<<UserName>>", name);
                    Console.WriteLine("name changed " + a);
                    return name;
                }
                else
                {
                    Console.WriteLine("enter minimum 3 charecters");
                }
            }
            else
            {
                Console.WriteLine("enter correct name");
            }
            
            return null;
        }
    }
}
