using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class HashImpl<H>
    {
        NodeList head;
        internal void Insert(int item)
        {
            NodeList node = new NodeList(item);
            NodeList n = head;
            if (n == null || (int)n.data >= item)
            {
                node.next = head;
                head = node;
            }
            else
            {
                while (n != null)
                {
                    if ((int)n.data <= item && n.next == null || (int)n.data <= item
                        && (int)n.next.data > item)
                    {
                        NodeList temp = n.next;
                        n.next = node;
                        node.next = temp;
                    }
                    n = n.next;
                }
            }
        }
        internal void Remove(int ele)
        {
            NodeList n = head;
            if (head.data.Equals(ele))
            {
                head = head.next;
            }
            else
            {
                while (n != null && n.next != null)
                {
                    if (n.next.data.Equals(ele))
                    {
                        n.next = n.next.next;
                    }
                    n = n.next;
                }
            }
        }
        internal void PrintHash()
        {
            NodeList n = head;
            while (n != null)
            {
                Console.WriteLine(n.data);
                n = n.next;
            }
        }
        internal Boolean Search(int item)
        {
            NodeList node = head;
            while (node.data.Equals(item) && node!=null)
            {
                return true;
            }
            node = node.next;
            return false;
        }
        
    }
}
