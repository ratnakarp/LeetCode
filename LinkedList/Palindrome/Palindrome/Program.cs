using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList();
            linkedList.AddFirst(1);
            linkedList.AddLast(3);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(3);
            linkedList.AddLast(2);
            linkedList.AddLast(1);
            linkedList.PrintAll();
        }
    }
}
