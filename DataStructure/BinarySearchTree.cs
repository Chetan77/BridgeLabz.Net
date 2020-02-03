using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BinarySearchTree<B>
    {
        BinaryNode root;

        internal void Ins(int ele)
        {
            root=Insert(root, ele);
        }
        internal BinaryNode Insert(BinaryNode root, int ele)
        {
            BinaryNode n = new BinaryNode(ele);
            if (root == null)
            {
                root = n;
            }
            if (ele < root.key)
            {
                root.left= Insert(root.left, ele);
            }
            else if (ele > root.key)
            {
                root.right= Insert(root.right, ele);
            }
            return root;
        }
        internal void PrintInOrder()
        {
            InorderRec(root);
        }
        void InorderRec(BinaryNode root)
        {
            if (root != null)
            {
                InorderRec(root.left);
                Console.WriteLine(root.key);
                InorderRec(root.right);
            }
        }
        internal static void BinaryTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            for (int i = 0; i < 10; i++)
            {
                tree.Ins(Utility.IntInput());

            }
            tree.PrintInOrder();
        }
    }
}
