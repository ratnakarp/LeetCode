using System;
using System.Collections.Generic;
using System.Text;

namespace StackOfStacks
{
    public class StackNodeList<T>
    {
        internal StackNode<T> StackNode;
        internal StackNodeList<T> Top;
        internal int maxcount = 5;
        internal int mincount = 1;

        public StackNodeList()
        {
        }

        private void AddFirst(T Data)
        {
            var myStackNodeList = new StackNodeList<T>();
            myStackNodeList.StackNode = new StackNode<T>(Data);
            myStackNodeList.Top = this.Top;
            this.Top = myStackNodeList;
        }

        private void AddLast(T Data)
        {
            var myStackNodeList = new StackNodeList<T>();
            myStackNodeList.StackNode = new StackNode<T>(Data);
            myStackNodeList.Top = this.Top;
            mincount = 1;
            this.Top = myStackNodeList;
        }

        public void Push(T Data)
        {
            if (this.Top == null )
            {
                this.AddFirst(Data);
            }
            else if (mincount > maxcount)
            {
                this.AddLast(Data);
            }
            else
            {
                StackNode<T> newNode = new StackNode<T>(Data);
                if (this.Top == null)
                {
                    newNode.Top = this.StackNode;
                    this.StackNode = newNode;
                }
                else
                {
                    newNode.Top = this.Top.StackNode;
                    this.Top.StackNode = newNode;
                }
            }
            mincount++;
        }
        public void Pop()
        {
            if(Top == null)
            {
                throw new Exception("Empty Stack Exception");
            }
            if(this.Top.StackNode == null)
            {
                this.Top = this.Top.Top;
            }
            this.Top.StackNode = this.Top.StackNode.Top;
        }

        public void PrintAll()      
        {
            if (this.Top.StackNode == null)
            {
                this.Top = this.Top.Top;
            }
            StackNodeList<T> nextNodeList = this.Top;
            int count = 1;
            while(nextNodeList != null)
            {
                Console.WriteLine("-------Stack "+ count.ToString() + " ------- Started");
                StackNode<T> nextStackNode = nextNodeList.StackNode;
                nextStackNode.PrintAll();
                nextNodeList = nextNodeList.Top;
                Console.WriteLine("-------Stack " + count.ToString() + " ------- Ended");
                count++;
            }
        }
    }
}
