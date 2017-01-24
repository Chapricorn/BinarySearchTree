using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> Children = new BinarySearchTree<int>(25);
            Children.AddLeaf(10);
            Children.AddLeaf(20);
            Children.AddLeaf(40);
            Children.AddLeaf(5);
            Children.AddLeaf(25);
            Children.AddLeaf(35);
            Console.ReadKey();
        }
    }
}
