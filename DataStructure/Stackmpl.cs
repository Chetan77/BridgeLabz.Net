using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Stackmpl<S>
    {
        Object[] stack = new object[100];
        int top = 0;
        internal void Push(S data)
        {
            top = top + 1;
            stack[top] = data;
        }
        internal S Pop()
        {
            if (top == 0)
            {
                Console.WriteLine("can't pop stack is empty");
            }
            else
            {

                S data = (S)stack[top];
                top--;
                return data;
            }
            return default(S);
        }
        internal S Peek()
        {
            return (S)stack[top];
        }
        internal Boolean isEmpty()
        {
            if (top == 0)
            {
                return true;
            }
            return false;
        }

        internal void PrintStack()
        {
            int i = 0;
            while (i <= top)
            {
                Console.WriteLine(stack[i]);
                i++;
            }
        }
        internal int Size()
        {
            return top;
        }

    }
}
