using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Node
    {
        public Object data;
        public Node next;
        public Node previous;
        public Node(object data)
        {
            
            this.data = data;
            this.next = null;
        }
    }
}
