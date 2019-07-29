using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Algorythim analisys of Binary Search Trees and it's basic operations
 * Goal: Improve knowledge about Binary Search Tree's data structure and improve practice
 * 
 * Binary Search Tree implementation through Nodes
 */
namespace Tree
{
    /// <summary>
    /// Class <c>MyTree</c> sets the Tree data structure
    /// </summary>
    /// <param name="HeadRoot">
    /// First Element added to the Tree
    /// </param>
    public class MyTree
    {
        public Node HeadRoot;

        /// <summary>
        ///  Class <c>Node</c> models the data informed in a node
        /// </summary>
        /// <param name="Right">
        /// Link to the node at the right
        /// </param>
        /// <param name="Left">
        /// Link to the node at the left
        /// </param>
        public class Node
        {
            public int Data;
            public Node Right { get; set; }
            public Node Left { get; set; }

            public Node(int data)
            {
                Data = data;
            }

            public override string ToString()
            {
                return Data.ToString();
            }
        }

        /// <summary>
        ///  Method <c>Insert</c> Adds a value as a node in the Tree folowing the binary search method
        /// </summary>
        /// <param name="Root">
        /// Current node / node to add the value recived
        /// </param>
        /// <param name="Value">
        /// Informed value that will be added to the Tree
        /// </param>
        /// <returns>
        /// Added node
        /// </returns>
        public Node Insert(Node Root, int Value)
        {             
            if(HeadRoot == null)
            {
                HeadRoot = new Node(Value);
                return HeadRoot;
            }
            else
            {
                if(Root == null)
                {
                    Root = new Node(Value);
                }
                else if (Value <= Root.Data)
                {
                    Root.Left = Insert(Root.Left, Value);
                }
                else if (Value > Root.Data)
                {
                    Root.Right = Insert(Root.Right, Value);
                }

                return Root;
            }

        }

        /// <summary>
        /// Method <c>Contains</c> Checks is the Tree contains the value informed
        /// </summary>
        /// <param name="Root">
        /// Current node to check if is equal the value informed
        /// </param>
        /// <param name="Value">
        /// Informed value to check if it part of the Tree
        /// </param>
        /// <returns>
        /// Boolean value indicating if the value informed is part of the Tree
        /// </returns>
        public Boolean Contains(Node Root, int Value)
        {
            if(Value == Root.Data)
            {
                return true;
            }
            else if (Value < Root.Data)
            {
                if(Root.Left == null)
                {
                    return false;
                }
                else
                {
                    return Contains(Root.Left, Value);
                }
            }
            else
            {
                if(Root.Right == null)
                {
                    return false;
                }
                else
                {
                    return Contains(Root.Right, Value);
                }
            }
        }

        /// <summary>
        /// Method <c>CheckBST</c> Checks if the Tree is a binary search tree
        /// </summary>
        /// <param name="Root">
        /// Current node to be analized
        /// </param>
        /// <param name="Min">
        /// Minimum value accepted for the node
        /// </param>
        /// <param name="Max">
        /// Maximum value accepted for the node
        /// </param>
        /// <returns>
        /// Boolean value indicating if the tree is a binary search tree
        /// </returns>
        public Boolean CheckBST (Node Root, int Min = int.MinValue, int Max = int.MaxValue)
        {
            if (Root == null)
            {
                return true;
            }
            if (Root.Data < Min || Root.Data > Max)
            {
                return false;
            }
            return CheckBST(Root.Left, Min, (Root.Data - 1)) && CheckBST(Root.Right, (Root.Data+1) ,Max);
        }
    }
}
