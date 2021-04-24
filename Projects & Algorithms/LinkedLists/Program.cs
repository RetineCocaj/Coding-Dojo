using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SLL list = new SLL();
            list.AddFront(10);
            list.AddFront(20);
            list.AddFront(30);
            list.AddFront(40);
            list.AddFront(50);
            Console.WriteLine("Values of list");
            Console.WriteLine(list.Display());

            list.RemoveFront();
            Console.WriteLine("\n\nAfter removing front node");
            Console.WriteLine(list.Display());

            Console.WriteLine("\n\nReturn front node");
            Console.WriteLine(list.Front());

            Console.WriteLine("\nDoes list contains value of 30?");
            Console.WriteLine(list.Contains(30) ? "Yes" : "No");

            Console.WriteLine("\nLength of list is");
            Console.WriteLine(list.Length());

            Console.WriteLine("\nMaximum value of list");
            Console.WriteLine(list.Max());
            
            Console.WriteLine("\nMinimum value of list");
            Console.WriteLine(list.Min());

            Console.WriteLine("\nAverage value of list");
            Console.WriteLine(list.Average());
        }
    }
}
