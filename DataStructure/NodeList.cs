using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class NodeList
    {
        public Object data;
        public NodeList next;

        public NodeList(Object data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
