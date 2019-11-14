using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome
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
            Node reverseNode = null;
            while (nextNode != null)
            {
                Console.WriteLine(nextNode.Data);
                if(reverseNode == null)
                {
                    reverseNode = new Node(nextNode.Data);
                }
                else
                {
                    Node nextReverseNode = reverseNode;
                    if (nextNode != null)
                    {
                        reverseNode = new Node(nextNode.Data);
                    }
                    reverseNode.Next = nextReverseNode;
                }
                nextNode = nextNode.Next;
            }

            nextNode = this.Head;
            bool flag = true;

            while (nextNode != null)
            {
                if (nextNode.Data != reverseNode.Data)
                {
                    Console.WriteLine("False");
                    flag = false;
                    break;
                }
                nextNode = nextNode.Next;
                reverseNode = reverseNode.Next;

            }
            if (flag)
                Console.WriteLine("True");
        }
    }
}
