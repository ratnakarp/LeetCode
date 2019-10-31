using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Partition
{
    public class Node
    {
        public Node(int d)
        {
            Data = d;
            Next = null;
        }
        public int Data { get; set; }
        public Node Next { get; set; }
    }
}
