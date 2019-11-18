using System;
using System.Collections.Generic;
using System.Text;

namespace QueueViaStacks
{
    public class MyQueue<T>
    {
        QueueNode<T> First;
        QueueNode<T> Last;

        public void Add(T item)
        {
            QueueNode<T> t = new QueueNode<T>(item);
            if(Last != null)
                Last.Next = t;

             Last = t;
            if(First == null)
            {
                First = Last;
            }
        }

        public T Remove()
        {
            if (First == null)
                throw new Exception("No elements found");

            T Data = First.Data;
            First = First.Next;
            if (First == null)
                Last = null;
            return Data;
        }

        public T Peek()
        {
            if(First == null)
            {
                throw new Exception("No elements found");
            }
            return First.Data;
        }

        public void PrintAll()
        {
            QueueNode<T> nextNode = this.First;
            while(nextNode != null)
            {
                Console.WriteLine(nextNode.Data);
                nextNode = nextNode.Next;
            }
        }
    }
}
