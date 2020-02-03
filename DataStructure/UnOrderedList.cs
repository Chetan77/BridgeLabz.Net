using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class UnOrderedList<U>
    {
		Node head;
        internal void AddData(U data)
        {
			Node n = new Node(data);
			if (head == null)
			{
				head = n;
			}
			else
			{
				Node node = head;
				while (node.next != null)
				{
					node = node.next;
				}
				node.next = n;
			}
		}
		internal void Remove(U data)
		{
			Node n = head;
			Node prev = null;
			if(head.data.Equals(data))
			{
				head = head.next;
				return;
			}
			while (!n.data.Equals(data))
			{
				prev = n;
				n = n.next;
			}
			n = n.next;
			prev.next = n;
		}
		internal Boolean Search(U item)
		{
			Node n = head;
			while (n.next != null)
			{
				if (n.data.Equals(item))
				{
					return true;
				}
				n = n.next;
			}
			return false;
		}
		internal Boolean IsEmpty()
		{
			if (head == null)
			{
				return true;
			}
			return false;
		}
		internal int Size()
		{
			Node node = head;
			int index = 0;
			while(node.next != null)
			{
				node = node.next;
				index++;
			}
			return index;
		}
		internal void Append(U item)
		{
			Node node = new Node(item);
			if (head == null)
			{
				head = node;
			}
			else
			{
				Node n = head;
				while (n != null)
				{
					n = n.next;
				}
				n = node;
			}
		}
		internal int Index(U item)
		{
			int index = 0;
			Node n = head;
			while (!n.data.Equals(item))
			{
				n = n.next;
				index++;
			}
			return index;
		}
		internal void InsertPos(U item,int pos)
		{
			int index = 1;
			Node n = head;
			Node prev = null;
			Node node = new Node(item);
			if (pos == 0)
			{
				node.next = head;
				head = node;
			}
			else
			{
				while (index != pos &&index<pos&& n!=null)
				{
					prev = n;
					n = n.next;
					index++;
				}
				prev.next = node;
				node.next = n;
			}
		}
		internal U Pop()
		{
			Node n = head;
			
			while (n.next != null &&n!=null)
			{
				n = n.next;
			}
			U ret = (U)n.data;
			n = null;
			return ret;
		}
		internal U PopPos(int pos)
		{
			Node n = head;
			int index = 1;
			Node prev = null;
			while(n !=null && index < pos)
			{
				prev = n;
				n = n.next;
				index++;
			}
			prev.next = n.next;
			return (U)n.data;
		}
		public void PrintList()
		{
			Node node = head;

			while (node != null)
			{
				Console.WriteLine(node.data);
				node = node.next;
			}
		}
	}
}
