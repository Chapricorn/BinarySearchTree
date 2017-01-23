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
            Children.Add(10);
            Children.Add(20);
            Children.Add(40);
            Children.Add(5);
            Children.Add(25);
            Children.Add(35);
            Console.ReadKey();
        }
    }
}
