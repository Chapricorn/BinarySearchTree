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
            Node<T> NewNode = new Node<T>(value);
            Node<T> CurrentNode = Parent, parent = null;
            while (CurrentNode != null)
            {
                result = CurrentNode.Value.CompareTo(NewNode.Value);
                if (result == 0)
                    return;
                else if (result > 0)
                {
                    parent = CurrentNode;
                    CurrentNode = CurrentNode.LeftChild;
                }
                else if (result < 0)
                {
                    parent = CurrentNode;
                    CurrentNode = CurrentNode.RightChild;
                }
            }
            if (parent == null)
            {
                CurrentNode = NewNode;
            }
            else
            {
                result = parent.Value.CompareTo(NewNode.Value);
                if (result > 0)
                {
                    parent.
                        LeftChild = NewNode;
                }
                else
                {
                    parent.RightChild = NewNode;
                }
            }
        }
        public bool NodeSearch(T value)
        {
            Node<T> CurrentNode = Parent;
            Node<T> NewNode = new Node<T>(value);
            while (CurrentNode != null)
            {
                result = CurrentNode.Value.CompareTo(NewNode.Value);
                if (result == 0)
                    return true;
                else if (result > 0)
                {
                    CurrentNode = CurrentNode.LeftChild;
                }
                else if (result < 0)
                {
                    CurrentNode = CurrentNode.RightChild;
                }
            }
            return false;
        }
    }
}




