using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class QueueImpl<Q>

    {
        int front = 0;
        int rear = 0;
        Object[] queue = new Object[1000];

        internal void EnQueue(Q data)
        {
            queue[rear] = data;
            rear++;
        }
        internal Q DeQueue()
        {
            if (queue[front] == null)
            {
                Console.WriteLine("queue is empty nothing to dequeue");
            }
            else
            {
                Q ele = (Q)queue[front];
                front++;
                return ele;
            }
            return (Q)default;
        }
        internal Boolean IsEmpty()
        {
            if (queue[front] == null)
            {
                return true;
            }
            return false;
        }
        internal int Size()
        {
            int count = front;
            int i = 0;
            while (count < rear)
            {
                i++;
                count++;
            }
            return i;
        }
    }
}
