using System;

namespace StackOfStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            StackNodeList<int> myStackNodeList = new StackNodeList<int>();
            myStackNodeList.Push(1);
            myStackNodeList.Push(2);
            myStackNodeList.Push(3);
            myStackNodeList.Push(4);
            myStackNodeList.Push(5);
            myStackNodeList.Push(6);
            myStackNodeList.Push(7);
            myStackNodeList.Push(8);
            myStackNodeList.Push(9);
            myStackNodeList.Push(10);
            myStackNodeList.Push(11);
            myStackNodeList.Push(12);
            myStackNodeList.Push(13);
            myStackNodeList.Push(14);
            myStackNodeList.Push(15);
            myStackNodeList.Push(16);
            myStackNodeList.Push(17);
            myStackNodeList.Push(18);
            myStackNodeList.Push(19);
            myStackNodeList.Push(20);
            myStackNodeList.Push(21);
            myStackNodeList.Push(22);
            myStackNodeList.Push(23);
            myStackNodeList.Push(24);
            myStackNodeList.Push(25);
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();
            myStackNodeList.Pop();

            myStackNodeList.PrintAll();
        }
    }
}
