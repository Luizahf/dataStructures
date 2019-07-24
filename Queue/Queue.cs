using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Queue
    {
        public class MyQueue<TNode>
        {
            private Node<TNode> Head;
            private Node<TNode> Tail;

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

            public void Push(TNode data)
            {
                Node<TNode> NewItem = new Node<TNode>(data);

                if (Tail != null)
                {
                    Tail.next = NewItem;
                }
                Tail = NewItem;
                if (Head == null)
                {
                    Head = NewItem;
                }
            }

           
            public void Pop(TNode data)
            {
                Head = Head.Next;
                if (Head == null)
                {
                    Tail==null;
                }
                
            }

            public Boolean IsEmpty()
            {
                return Head == null;
            }

            public TNode Peek()
            {
                return Head.Data;
            }
        }
    }
}
