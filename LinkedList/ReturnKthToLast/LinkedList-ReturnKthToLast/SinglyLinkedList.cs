using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_ReturnKthToLast
{
    public class SinglyLinkedList
    {
        public Node Head;

        public int Count = 0;
           
        public void PrintKthToLast(int kth)
        {
            Node nextNode = this.Head;
            var count = 0;
            while (nextNode != null)
            {
                if(count >= kth)
                {
                    Console.WriteLine(nextNode.Data);
                }
                count++;
                nextNode = nextNode.Next;
            }
        }
    }
}
