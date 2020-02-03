using System;

namespace DataStructure
{
    public class OrderedList<O>
    {
        Node head;
        public void ListData(int data)
        {
            Node n = head;
            Node node = new Node(data);
            if (head == null ||(int)n.data>(int)node.data)
            {
                node.next = head;
                head = node;
                //Console.WriteLine(head.data);
            }
            else
            {
                while (n.next !=null && (int)n.next.data<(int)node.data)
                {
                    n = n.next;
                    //Console.WriteLine(n.data);
                }
                node.next = n.next;
                //Console.WriteLine(n.data);
                n.next = node;
            }
        }
        public int Size()
        {
            Node node = head;
            int ind=1;
            while (node.next != null)
            {
                node = node.next;
                ind++;
            }
            return ind;
        }
        public void PrintList()
        {
            Node node = head;
            
            while(node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            node = null;
        }
        internal int Remove(O data)
        {
            Node node = head.next;
            Node prev = null;
            if (head.data.Equals(data))
            {
                head = head.next;
                return (int)head.data;
            }
            else
            {
                while (!node.data.Equals(data))
                {
                    prev = node;
                    node = node.next;
                }
                int ret = (int)node.data;
                 node= node.next;
                prev.next = node;

                return ret;
            }
        }
        public Boolean Search(O data)
        {
            Node node = head;
            if(head.data.Equals(data)) {
                return true;
            }
            else
            {
                while (!node.next.data.Equals(data))
                {
                    node = node.next;
                    return false;
                }
                    return true;
            }
        }
    }
}
