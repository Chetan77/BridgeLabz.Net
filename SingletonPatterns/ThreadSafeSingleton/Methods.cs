using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadSafeSingleton
{
    class Methods
    {

        private Methods()
        {
            Console.WriteLine("invoked " + GetType());
        }
        private static Methods obj = null;
        private static Object ob = new Object();
        public static Methods GetObject
        {
            get
            {
                if (obj == null)
                {
                    lock (ob)
                    {
                        if (obj == null)
                        {
                            obj = new Methods();
                        }
                    }
                }
                return obj;
            }
        }
    }
}
