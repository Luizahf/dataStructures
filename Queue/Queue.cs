using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Algorythim analisys of Queues and it's basic operations
 * Goal: Improve knowledge about queue data structures and improve practice
 * 
 * Queue implementation through Nodes
 */

namespace Queue1
{
    class Queue
    {
        public class MyQueue<TNode>
        {
            private Node<TNode> Front;
            private Node<TNode> Back;

            // Creates a Node with the data informed and sets the Next attr
            private class Node<TNode>
            {
                public TNode Data;
                public Node<TNode> Next { get; set; }

                public Node(TNode data)
                {
                    Data = data;
                }

                public override string ToString()
                {
                    return Data.ToString();
                }
            }

            // Adds/Stores data as a Node in the back of the Queue
            public void Enqueue(TNode data)
            {
                Node<TNode> NewItem = new Node<TNode>(data);

                if (Back != null)
                {
                    Back.Next = NewItem;
                }
                Tail = NewItem;
                if (Front == null)
                {
                    Front = NewItem;
                }
            }

            // Removes the first data Node of the Queue
            public void Dequeue()
            {
                Front = Front.Next;
                if (Front == null)
                {
                    Back == null;
                }

            }

            // Checks if the Queue is empty
            public Boolean IsEmpty()
            {
                return Front == null;
            }

            // Shows the element that's in the front of the Queue
            public TNode getFront()
            {
                return Front.Data;
            }
        }
    }
}