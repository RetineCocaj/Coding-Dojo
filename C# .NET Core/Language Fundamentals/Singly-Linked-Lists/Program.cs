using System;

namespace Singly_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.PrintValues();

            list.RemoveLast();
            Console.WriteLine("\n\nAfter removing last node");
            list.PrintValues();
        }
    }
}
