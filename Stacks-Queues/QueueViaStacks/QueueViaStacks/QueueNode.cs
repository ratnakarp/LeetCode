using System;
using System.Collections.Generic;
using System.Text;

namespace QueueViaStacks
{
    public class QueueNode<T>
    {
        public QueueNode<T> Next;
        public T Data;
        public QueueNode(T Data)
        {
            this.Data = Data;
        }
    }
}
