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
            private Node<TNode> Front;
            private Node<TNode> Back;

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

            public void Enqueue(TNode data)
            {
                Node<TNode> NewItem = new Node<TNode>(data);

                if (Back != null)
                {
                    Back.next = NewItem;
                }
                Tail = NewItem;
                if (Front == null)
                {
                    Front = NewItem;
                }
            }


            public void Dequeue(TNode data)
            {
                Front = Front.Next;
                if (Front == null)
                {
                    Back == null;
                }

            }

            public Boolean IsEmpty()
            {
                return Front == null;
            }

            public TNode getFront()
            {
                return Front.Data;
            }
        }
    }
}