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
        /// <summary>
        /// Class <c>MyQueue</c> sets the Queue data structure
        /// <summary>
        /// <param name="Front">
        /// First element added to the Queue
        /// </param>
        /// <param name="Back">
        /// Last element added to the Queue
        /// </param>
        public class MyQueue<TNode>
        {
            private Node<TNode> Front;
            private Node<TNode> Back;

            /// <summary>
            /// Class <c>Node</c> models the data informed in a node 
            /// </summary>
            /// <param name="Next"> 
            /// Link to the next Node
            /// </param>
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

            /// <summary>
            /// Method <c>Enqueue</c> Adds/Stores data as a Node in the back of the Queue
            /// </summary>
            /// <param name="data">
            /// Informed data that will be added to the Queue 
            /// </param>
            public void Enqueue(TNode data)
            {
                Node<TNode> NewItem = new Node<TNode>(data);

                if (Back != null)
                {
                    Back.next = NewItem;
                }
                Back = NewItem;
                if (Front == null)
                {
                    Front = NewItem;
                }
            }

            /// <summary>
            /// Method <c>Dequeue</c> Removes the first data Node of the Queue
            /// </summary>
            public void Dequeue()
            {
                Front = Front.Next;
                if (Front == null)
                {
                    Back == null;
                }

            }

            /// <summary>
            /// Method <c>IsEmpty</c> Checks if the Queue is empty
            /// </summary>
            /// <returns> 
            /// Boolean value triggered when the Queue is null 
            /// </returns>
            public Boolean IsEmpty()
            {
                return Front == null;
            }

            /// <summary>
            /// Method <c>getFront</c> Shows the element that's in the front of the Queue
            /// </summary>
            /// <returns> 
            /// <c>Front</c> value: The first element int he Queue
            /// </returns>
            public TNode getFront()
            {
                return Front.Data;
            }
        }
    }
}