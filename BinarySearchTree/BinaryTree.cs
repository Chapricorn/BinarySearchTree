using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //    class BinaryTree
    //    {
    //        public Node Parent;
    //        public BinaryTree()
    //        {
    //            Parent = null;
    //        }

    //        public void AddNumberList(int value)
    //        {
    //            Node newNode = new Node(value);
    //            AddNode(ref Parent, newNode);
    //        }

    //        public void AddNode(ref Node currentNode, Node newNode)
    //        {
    //            if (currentNode == null)
    //            {
    //                currentNode = newNode;
    //            }
    //            else
    //            {
    //                if (newNode.number.CompareTo(currentNode.number) < 0)
    //                {
    //                    if (currentNode.leftChild == null)
    //                    {
    //                        currentNode.leftChild = newNode;
    //                    }
    //                    else
    //                    {
    //                        AddNode(ref currentNode.leftChild, newNode);
    //                    }
    //                }
    //                else if (newNode.number.CompareTo(currentNode.number) > 0)
    //                {
    //                    if (currentNode.rightChild == null)
    //                    {
    //                        currentNode.rightChild = newNode;
    //                    }
    //                    else
    //                    {
    //                        AddNode(ref currentNode.rightChild, newNode);
    //                    }
    //                }
    //            }
    //        }
    //        public void Display()
    //        {
    //            if (Parent == null)
    //            {
    //                Console.WriteLine();
    //            }
    //            else
    //            {
    //                Node currentNode = Parent;
    //                DisplayNode(Parent);
    //            }
    //        }
    //        public void DisplayNode(Node nodeNumber)
    //        {
    //            if (nodeNumber != null)
    //            {
    //                Console.WriteLine("Numbers in this Tree: {0}", nodeNumber.number);
    //                DisplayNode(nodeNumber.leftChild);
    //                DisplayNode(nodeNumber.rightChild);
    //            }
    //        }

    //        public Node Search(int value)
    //        {
    //            Console.WriteLine();
    //            Console.WriteLine("Search for the Number {0}", value);
    //            Console.WriteLine("Number {0} is found!", value);
    //            if (Parent == null)
    //            {
    //                Console.WriteLine("Null tree.");
    //                return Parent;
    //            }
    //            else
    //            {
    //                if (Parent.number.CompareTo(value) == 0)
    //                {
    //                    Console.WriteLine("{0} is the Parent of the tree.", value);
    //                    return Parent;
    //                }
    //                else
    //                {
    //                    return SearchNode(Parent, value);
    //                }
    //            }
    //        }

    //        public Node SearchNode(Node currentNode, int value)
    //        {
    //            if (currentNode == null)
    //            {
    //                return currentNode;
    //            }
    //            else
    //            {
    //                if (currentNode.number.CompareTo(value) == 0)
    //                {
    //                    return currentNode;
    //                }
    //                else if (currentNode.number.CompareTo(value) < 0)
    //                {
    //                    Console.WriteLine("Adding {0} to the rightChild of the Tree.", value);
    //                    return SearchNode(currentNode.rightChild, value);
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Adding {0} to the leftChild of the Tree.", value);
    //                    return SearchNode(currentNode.leftChild, value);
    //                }
    //            }
    //        }

    //    }

    class BinarySearchTree<TKey, TValue> : IEnumerable<Nodes<TKey, TValue>> where TKey : IComparable<TKey>
{
    private Nodes<TKey, TValue> _root;

    public bool Search(TKey key, out TValue value)
    {
        Nodes<TKey, TValue> node = _root;

        while (node != null)
        {
            if (key.CompareTo(node.Key) < 0)
            {
                node = node.Left;
            }
            else if (key.CompareTo(node.Key) > 0)
            {
                node = node.Right;
            }
            else
            {
                value = node.Value;
                return true;
            }
        }

        value = default(TValue);

        return false;
    }

    public void Add(TKey key, TValue value)
    {
        if (_root == null)
        {
            _root = new Nodes<TKey, TValue>(key, value);
        }
        else
        {
            Nodes<TKey, TValue> node = _root;

            while (node != null)
            {
                int comaprisonResult = node.Key.CompareTo(key);

                if (comaprisonResult < 0)
                {
                    Nodes<TKey, TValue> left = node.Left;

                    if (left == null)
                    {
                        node.Left = new Nodes<TKey, TValue>(key, value, node);
                        return;
                    }
                    node = left;
                }
                else if (comaprisonResult > 0)
                {
                    Nodes<TKey, TValue> right = node.Right;

                    if (right == null)
                    {
                        node.Right = new Nodes<TKey, TValue>(key, value, node);
                        return;
                    }
                    node = right;
                }
                else
                {
                    node.Key = key;
                    node.Value = value;
                    return;
                }
            }
        }
    }
    private static void Replace(Nodes<TKey, TValue> target, Nodes<TKey, TValue> source)
    {
        Nodes<TKey, TValue> left = source.Left;
        Nodes<TKey, TValue> right = source.Right;

        target.Key = source.Key;
        target.Value = source.Value;
        target.Left = left;
        target.Right = right;

        if (left != null)
        {
            left.Parent = target;
        }

        if (right != null)
        {
            right.Parent = target;
        }
    }
    IEnumerator<Nodes<TKey, TValue>> IEnumerable<Nodes<TKey, TValue>>.GetEnumerator()
    {
        return _root.GetEnumerator();
    }
    public IEnumerator GetEnumerator()
    {
        return ((IEnumerable)_root).GetEnumerator();
    }
}
}


