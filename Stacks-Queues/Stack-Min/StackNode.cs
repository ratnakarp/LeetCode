using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Min
{
    public class StackNode<T>
    {
        public T Data;
        public StackNode<T> Next;

        public T MinNode;

        public StackNode(T data)
        {
            Data = data;
        }
    }
}
