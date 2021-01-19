using System;
using System.Collections.Generic;
using System.Text;

namespace DataStrctures.LinkedLists
{
    public class LinkedListMain
    {
        public void Main()
        { 
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Head = new LinkedList<int>.Node
            {
                Data = 1,
                Next = null
            };
            linkedList.Head.Next = new LinkedList<int>.Node
            {
                Data = 2,
                Next = null
            };
            linkedList.Head.Next.Next = new LinkedList<int>.Node
            {
                Data = 3,
                Next = null
            };
            linkedList.Head.Next.Next.Next = new LinkedList<int>.Node
            {
                Data = 4,
                Next = null
            };
            linkedList.Head.Next.Next.Next.Next = new LinkedList<int>.Node
            {
                Data = 5,
                Next = null
            };

            Console.WriteLine(linkedList.ListLength(linkedList.Head));
            linkedList.DisplayList(linkedList.Head);
            linkedList.Head=linkedList.InsertAtBeginning(linkedList.Head, 10);
            linkedList.Head = linkedList.InsertAtBeginning(linkedList.Head, 11);
            linkedList.Head = linkedList.InsertAtBeginning(linkedList.Head, 12);
            linkedList.Head = linkedList.InsertAtBeginning(linkedList.Head, 10);
            linkedList.Head = linkedList.InsertAtBeginning(linkedList.Head, 11);
            linkedList.Head = linkedList.InsertAtBeginning(linkedList.Head, 12);

            linkedList.Head = linkedList.InsertInMiddle(linkedList.Head, 100, 6);
            linkedList.Head = linkedList.InsertAtEnd(linkedList.Head, 200);
            linkedList.DisplayList(linkedList.Head);
        }
    }
}
