using System;

namespace QueueViaStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> a = new MyQueue<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.Add(5);
            a.Add(6);
            a.Add(7);
            a.Remove();
            a.PrintAll();
        }
    }
}
