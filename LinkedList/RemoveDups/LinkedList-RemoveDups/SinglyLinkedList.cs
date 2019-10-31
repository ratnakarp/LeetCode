using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_RemoveDups
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Data = data;
            newNode.Next = this.Head;
            this.Head = newNode;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);

            if (this.Head == null)
            {
                this.Head = newNode;
                return;
            }

            Node nextNode = this.Head;
            while(nextNode.Next != null)
            {
                nextNode = nextNode.Next;
            }
            nextNode.Next = newNode;
            return;

        }

        public void PrintAll()
        {
            Node nextNode = this.Head;
            while(nextNode != null)
            {
                Console.WriteLine(nextNode.Data);
                nextNode = nextNode.Next;
            }
        }

        public void RemoveDups()
        {
            Node nextNode = this.Head;
            Node prevNode = this.Head;
            bool[] nodeExists = new bool[4];
            
            while (nextNode != null)
            {
                if (nodeExists[nextNode.Data])
                {
                    prevNode.Next = nextNode.Next;
                }
                prevNode = nextNode;
                nodeExists[nextNode.Data] = true;
                nextNode = nextNode.Next;
            }
        }
    }
}
