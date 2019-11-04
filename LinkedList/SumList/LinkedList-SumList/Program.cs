using System;

namespace LinkedList_SumList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList1 = new SinglyLinkedList();
            linkedList1.AddFirst(7);
            linkedList1.AddLast(1);
            linkedList1.AddLast(6);

            var linkedList2 = new SinglyLinkedList();
            linkedList2.AddFirst(5);
            linkedList2.AddLast(9);
            linkedList2.AddLast(2);

            var linkedList3 = linkedList1.SumList(linkedList1, linkedList2);
            linkedList3.PrintAll();

        }
    }
}
