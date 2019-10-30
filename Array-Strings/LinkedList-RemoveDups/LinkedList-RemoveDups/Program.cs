using System;

namespace LinkedList_RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList();
            linkedList.AddFirst(1);
            linkedList.AddFirst(1);
            linkedList.AddLast(2);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(3);
            linkedList.PrintAll();
            linkedList.RemoveDups();
            linkedList.PrintAll();
        }
    }
}
