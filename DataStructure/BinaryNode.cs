using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BinaryNode
    {
        public int key;
        public BinaryNode left, right;

        public BinaryNode(int key)
        {
            this.key = key;
            this.left = null;
            this.right = null;
        }
    }
}
