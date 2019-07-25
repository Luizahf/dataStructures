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
        public class MyStack<TNode>
        {
            // Sets the Stack attr top
            private Node<TNode> Top;

            // Creates a Node with the data and sets "next" attr
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

            // Creates a new Node with the given data and pushes it on top of the stack
            public void Push(TNode data)
            {
                Node<TNode> NewItem = new Node<TNode>(data);
                NewItem.Next = Top;
                Top = NewItem;
            }

            // Removes the top Node of the Stack
            public void Pop()
            {
                Top = Top.Next;
            }
            // Returns the top Node
            public TNode Peek()
            {
                return Top.Data;
            }
            // Checks if the Stack is empty
            public Boolean IsEmpty()
            {
                return Top == null;
            }
        }
    }
}