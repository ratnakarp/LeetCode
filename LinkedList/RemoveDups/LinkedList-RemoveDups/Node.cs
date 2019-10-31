using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_RemoveDups
{
    public class Node
    {
        public int Data;
        public Node Next;
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
    }
}
