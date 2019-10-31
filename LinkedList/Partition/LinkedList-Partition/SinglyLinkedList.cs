using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Partition
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
            while (nextNode.Next != null)
            {
                nextNode = nextNode.Next;
            }
            nextNode.Next = newNode;
            return;

        }

        public void PrintAll()
        {
            Node nextNode = this.Head;
            while (nextNode != null)
            {
                Console.WriteLine(nextNode.Data);
                nextNode = nextNode.Next;
            }
        }

        public void Partition(int x)
        {
            Node nextNode = this.Head;
            Node greaterNode = null;
            while (nextNode != null)
            {
                //if (nextNode.Data < x)
                //{
                //    Node lesserNode = null;
                //    lesserNode = nextNode;
                //    nextNode.Next = lesserNode;
                //}
                if (nextNode.Next != null && nextNode.Data < nextNode.Next.Data && nextNode.Data < x)
                {
                    if (greaterNode == null)
                    {
                        greaterNode = new Node(nextNode.Next.Data);
                        nextNode.Next = nextNode.Next.Next;
                    }
                }
                else
                {
                    if (greaterNode == null && nextNode.Next != null)
                    {
                        greaterNode = new Node(nextNode.Next.Data);
                        greaterNode.Next = null;
                    }
                    else
                    {
                        if (nextNode.Next != null)
                        {
                            var newNode = new Node(nextNode.Next.Data);
                            greaterNode.Next = newNode;
                        }
                    }
                }
                nextNode = nextNode.Next;
            }
          //  nextNode.Next = greaterNode;
        }
    }
}
