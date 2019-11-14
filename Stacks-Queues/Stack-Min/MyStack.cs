using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Min
{
    public class MyStack<T>
    {
        private StackNode<T> Top;

        public T pop()
        {
            if(Top == null)
            {
                throw new Exception("Empty Stack Exception");
            }
            T item = Top.Data;
            Top = Top.Next;
            return item;
        }

        public void Push(T item)
        {
            StackNode<T> newNode = new StackNode<T>(item);
            newNode.Next = Top;
            Top = newNode;
            Top.MinNode = Top  newNode ? Top : newNode;
        }

        public T Peek()
        {
            if(Top == null)
            {
                throw new Exception("Empty Stack Exception");
            }
            return Top.Data;
        }
        public bool isEmpty()
        {
            return Top == null;
        }

        public T Min()
        {
            return Top.MinNode;
        }

        public void PrintAll()
        {
            StackNode<T> nextNode = this.Top;
            while(nextNode != null)
            {
                Console.WriteLine(nextNode.Data);
                nextNode = nextNode.Next;
            }
        }
    }
}
