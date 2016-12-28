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
            BinaryTree children = new BinaryTree();
            children.AddNumberList(10);
            children.AddNumberList(5);
            children.AddNumberList(7);
            children.AddNumberList(15);
            children.AddNumberList(12);
            children.AddNumberList(4);
            
            children.Display();

            children.Search(10);
            children.Search(5);
            children.Search(7);
            children.Search(15);
            children.Search(12);
            children.Search(4);


            Console.ReadKey();
        }
    }
}
