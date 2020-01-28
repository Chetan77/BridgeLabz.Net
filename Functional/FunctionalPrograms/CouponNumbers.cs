using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class CouponNumbers
    {
        public static int getCoupon(int n)
        {
            Random random = new Random();
            int a = random.Next();
            return a;
        }

        public static int collect()          
        {
            int n = 10;
            Boolean[] isCollected = new Boolean[n];
            int count = 0;                
            int distinct = 1;
            while (distinct < n)
            {
                int value = getCoupon(n);            
                count++;                             
                if (!isCollected[value])
                {           // discovered a new card type
                    distinct++;
                    isCollected[value] = true;
                }
            }
            return count;
        }

        
    }
}
