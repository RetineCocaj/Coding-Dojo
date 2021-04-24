using System;

namespace Fronts
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
            list.PrintValues();

            list.RemoveFront();
            Console.WriteLine("\n\nAfter removing front node");
            list.PrintValues();

            Console.WriteLine("\n\nReturn front node");
            Console.WriteLine(list.Front());

            Console.WriteLine("\noes list contains value of 30?");
            Console.WriteLine(list.Contains(30) ? "Yes" : "No");


        }
    }
}
