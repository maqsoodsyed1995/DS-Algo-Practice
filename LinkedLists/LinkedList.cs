using System;

namespace DataStrctures.LinkedLists
{
    public class LinkedList<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
        }

        public Node Head;

        public int ListLength(Node headNode)
        {
            if (headNode == null)
                return 0;
            int length = 0;
            while (headNode!=null)
            {
                headNode = headNode.Next;
                length++;
            }
            return length;
        }

        public void DisplayList(Node heaNode)
        {
            if (heaNode == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            while (heaNode != null)
            {
                Console.Write(heaNode.Data+"->");
                heaNode = heaNode.Next;
            }
            Console.WriteLine();
        }

        public Node InsertAtBeginning(Node headNode, T data)
        {
            if (headNode == null)
            {
                headNode = new Node
                {
                    Data = data,
                    Next = null
                };
                return headNode;
            }

            Node tempNode = new Node
            {
                Data = data,
                Next = headNode
            };

            headNode = tempNode;

            return headNode;
        }

        public Node InsertInMiddle(Node headNode, T data, int position)
        {
            int listLength = ListLength(headNode);

            if (position > listLength || position < 1)
            {
                Console.WriteLine("Invalid Position");
                return headNode;
            }

            if (position == 1)
            {
                headNode=InsertAtBeginning(headNode, data);
                return headNode;
            }

            Node tempHeadNode = headNode;
            int count = 1;
            while (count<position-1)
            {
                tempHeadNode = tempHeadNode.Next;
                count++;
            }

            Node newNode = new Node
            {
                Data = data,
                Next = tempHeadNode.Next
            };

            tempHeadNode.Next = newNode;

            return headNode;
        }

        public Node InsertAtEnd(Node headNode, T data)
        {
            if (headNode == null)
            {
                return new Node
                {
                    Data = data,
                    Next = null
                };
            }

            Node tempHeadNode = headNode;
            while (tempHeadNode.Next!=null)
            {
                tempHeadNode = tempHeadNode.Next;
            }

            tempHeadNode.Next = new Node
            {
                Data = data,
                Next = null
            };

            return headNode;
        }


    }
}
