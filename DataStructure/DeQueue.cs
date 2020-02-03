using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class DeQueue<D>
    {
        Node front;
        Node rear;
        int count = 0;
        internal void AddFront(D data)
        {
            Node newNode = new Node(data);
            //newNode.next = null;
            if (IsEmpty())
            {
                rear = newNode;
                count++;
            }
            else
            {
                front.previous = newNode;
                count++;
            }
            newNode.next = front;
            front = newNode;
        }
        internal void AddRear(D data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                front = node;
                count++;
            }
            else
            {
                rear.next = node;
                node.previous = rear;
                count++;
            }
            rear = node;
        }
        internal D RemoveFront()
        {
            D sa = (D)front.data;
            if (front.next == null)
            {
                rear = null;

            }
            else
            {
                front.next.previous = null;
                count--;
            }
            front = front.next;
            return sa;
        }
        internal D RemoveRear()
        {
            D ele = (D)rear.data;
            if (front.next == null)
            {
                front = null;
                count--;
            }
            else
            {
                rear.previous.next = null;
            }
            rear = rear.previous;
            count--;

            return ele;
        }
        public Boolean IsEmpty()
        {
            return (front == null);
        }
        public int Size()
        {
            return count;
        }
        internal void PrintDeQueue()
        {
            Node n = front;
            if (front == null)
            {
                Console.WriteLine("Dequeue is empty");
            }
            else
            {
                while (n != null)
                {
                    Console.WriteLine(n.data);
                    n = n.next;
                }
            }
        }
        public static void DequeueTtest()
        {
            DeQueue<string> deQueue = new DeQueue<string>();
            Console.WriteLine("enter number of elements");
            int num = Utility.IntInput();
            for (int i = 0; i < num; i++)
            {
                deQueue.AddFront(Utility.StringInput());
            }
            Console.WriteLine("enter number of elements");
            int na = Utility.IntInput();
            for (int i = 0; i < na; i++)
            {
                deQueue.AddRear(Utility.StringInput());
            }
            Console.WriteLine("enter number of elements");
            int n = Utility.IntInput();
            for (int i = 0; i < n; i++)
            {
                deQueue.AddFront(Utility.StringInput());
            }
            Console.WriteLine(deQueue.RemoveFront());
            Console.WriteLine(deQueue.RemoveRear());
            Console.WriteLine(deQueue.Size());

            deQueue.PrintDeQueue();
        }
    }
}
