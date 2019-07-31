using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Algorythim analisys of Stacks and it's basic operations
 * Goal: Improve knowledge about stack data structures and improve practice
 * 
 * Stack implementation through Nodes
 */

namespace Stack
{
    class Stack
    {
        /// <summary>
        /// Class <c>MyStack</c> sets the Stack data structure
        /// <summary>
        /// <param name="Top">
        /// Last element added to the Stack
        /// </param>
        public class MyStack<TNode>
        {
            private Node<TNode> Top;

            /// <summary>
            /// Class <c>Node</c> Creates a Node with the data
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
            /// Method <c>Push</c> Creates a new Node with the given data and pushes it on top of the stack
            /// </summary>
            /// <param name="data">
            /// Informed data that will be added to the Stack
            /// </param>
            public void Push(TNode data)
            {
                Node<TNode> NewItem = new Node<TNode>(data);
                NewItem.Next = Top;
                Top = NewItem;
            }

            /// <summary>
            /// Method <c>Pop</c> Removes the top Node of the Stack
            /// </summary>
            public void Pop()
            {
                Top = Top.Next;
            }

            /// <summary>
            /// Method <c>Peek</c> Shows the element that's on top of the Stack
            /// </summary>
            /// <returns> 
            /// <c>Top</c>: The top element of the stack
            /// </returns>
            public TNode Peek()
            {
                return Top.Data;
            }

            /// <summary>
            /// Method <c>IsEmpty</c> Checks if the Stack is empty
            /// </summary>
            /// <returns> 
            /// Boolean value triggered when the Stack is null 
            /// </returns>
            public Boolean IsEmpty()
            {
                return Top == null;
            }
        }
    }
}