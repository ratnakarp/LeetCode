using System;
using System.Collections.Generic;
using System.Text;

namespace StackOfStacks
{
    public class StackNode<T>
    {
        private T data;
        public int MaxStackCount { get; set; }

        public StackNode<T> Top;
        public StackNode(T Data)
        {
            data = Data;
        }

        public void PrintAll()
        {
            StackNode<T> nextStackNode = this;
            while(nextStackNode != null )
            {
                Console.WriteLine(nextStackNode.data);
                nextStackNode = nextStackNode.Top;
            }
        }
    }
}
