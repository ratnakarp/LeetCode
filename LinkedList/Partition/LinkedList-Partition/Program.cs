using System;

namespace LinkedList_Partition
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new SinglyLinkedList();
            linkedList.AddFirst(3);
            linkedList.AddLast(5);
            linkedList.AddLast(8);
            linkedList.AddLast(5);
            linkedList.AddLast(10);
            linkedList.AddLast(2);
            linkedList.AddLast(1);
            //linkedList.PrintAll();
            linkedList.Partition(5);
            linkedList.PrintAll();
            Console.ReadKey();
        }
    }
}
