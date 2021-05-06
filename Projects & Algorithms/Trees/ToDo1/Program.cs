using System;

namespace ToDo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            tree.Add(50);
            tree.Add(40);
            tree.Add(30);
            tree.Add(20);
            tree.Add(100);
            tree.Display(tree.Root);
            Console.WriteLine(tree.Contains(0));
            Console.WriteLine(tree.Size());
            Console.WriteLine(tree.IsEmpty());

        }
    }
}
