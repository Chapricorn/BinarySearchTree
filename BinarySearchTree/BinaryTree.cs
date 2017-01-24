using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        Node<T> Parent;
        int result;
        public BinarySearchTree(T value)
        {
            Parent = new Node<T>(value);
        }
        public void AddLeaf(T value)
        {
            int result;
            Node<T> NodePath = new Node<T>(value);
            Node<T> NewNode = Parent, parent = null;
            while (NewNode != null)
            {
                result = NewNode.Value.CompareTo(NodePath.Value);
                if (result == 0)
                    return;
                else if (result > 0)
                {
                    parent = NewNode;
                    NewNode = NewNode.LeftChild;
                }
                else if (result < 0)
                {
                    parent = NewNode;
                    NewNode = NewNode.RightChild;
                }
            }
            if (parent == null)
            {
                NewNode = NodePath;
            }
            else
            {
                result = parent.Value.CompareTo(NodePath.Value);
                if (result > 0)
                {
                    parent.
                        LeftChild = NodePath;
                }
                else
                {
                    parent.RightChild = NodePath;
                }
            }
        }
        public bool NodeSearch(T value)
        {
            Node<T> NewNode = Parent;
            Node<T> NodePath = new Node<T>(value);
            while (NewNode != null)
            {
                result = NewNode.Value.CompareTo(NodePath.Value);
                if (result == 0)
                    return true;
                else if (result > 0)
                {
                    NewNode = NewNode.LeftChild;
                }
                else if (result < 0)
                {
                    NewNode = NewNode.RightChild;
                }
            }
            return false;
        }
    }
}




