using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BankCashCounter
    {
        public static void BankCashCounterImpl()
        {
            QueueImpl<string> queueImpl = new QueueImpl<string>();
            Console.WriteLine("enter how mwny people are there in counter");
            int peoples = Utility.IntInput();
            for (int i = 0; i < peoples; i++)
            {
                Console.WriteLine("enter name");
                queueImpl.EnQueue(Utility.StringInput());
            }
            int size = 0;
            Console.WriteLine("enete yes if withdraw or deposite is done");
            string s = Utility.StringInput();
            size = queueImpl.Size();
            while (s.Equals("yes") && size > 0)
            {
                String strt = queueImpl.DeQueue();
                Console.WriteLine("dequeued element is" + strt);
                Console.WriteLine("enter yes if next persons transaction has done");
                s = Utility.StringInput();
                size = queueImpl.Size();
            }
            Console.WriteLine("size of the queue is" + size);
        }
    }
}
