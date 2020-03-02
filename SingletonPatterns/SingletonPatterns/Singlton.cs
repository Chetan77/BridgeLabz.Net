using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatterns
{
    public sealed class Singlton
    {
        private Singlton()
        {
            Console.WriteLine("invoked " + GetType());
        }
        private static Lazy<Singlton> obj = new Lazy<Singlton>(()=>new Singlton());
        //private static Object ob = new Object();
        public static Singlton GetObject
        {
            get
            {
               /* if (obj == null)
                {
                    lock (ob)
                    {
                        if (obj == null)
                        {
                            obj = new Singlton();
                        }
                    }
                }*/
                return obj.Value;
            }
        }
        public void Print(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}
