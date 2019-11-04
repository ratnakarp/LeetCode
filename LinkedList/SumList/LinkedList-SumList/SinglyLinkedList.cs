using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_SumList
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

        public SinglyLinkedList SumList(SinglyLinkedList list1 , SinglyLinkedList list2)
        {
            Node nextNode = list1.Head;
            int list1Int = 0;
            int list2Int = 0;
            int multiply10 = 10;
            int count = 0;
            while (nextNode != null)
            {
                if (count == 0)
                {
                    list1Int += nextNode.Data;
                }
                else
                {
                    list1Int += nextNode.Data * multiply10;
                    multiply10 *= multiply10;
                }

                count++;

                nextNode = nextNode.Next;
            }

            nextNode = list2.Head;
            multiply10 = 10;
            count = 0;
            while (nextNode != null)
            {
                if (count == 0)
                {
                    list2Int += nextNode.Data;
                }
                else
                {
                    list2Int += nextNode.Data * multiply10;
                    multiply10 *= multiply10;
                }

                count++;

                nextNode = nextNode.Next;
            }

            var output = list1Int + list2Int;

            var linkedList3 = new SinglyLinkedList();
            count = 0;
            int n = output;
            while (n != 0)
            {
                if (count == 0)
                    linkedList3.AddFirst(n % 10);
                else
                    linkedList3.AddLast(n % 10);
                count++;

                n = n / 10;
            }

            return linkedList3;
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

    }
}
