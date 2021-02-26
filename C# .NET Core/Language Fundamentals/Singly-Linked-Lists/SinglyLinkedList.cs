using System;
namespace Singly_Linked_Lists
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList() 
        {
            Head = null;
        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public void Add(int value) 
        {
            SllNode newNode = new SllNode(value);
            if(Head == null) 
            {
                Head = newNode;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        } 
        public void RemoveLast() 
        {
            if(Head != null)
            {
                if(Head.Next == null) Head = null;
                else
                {
                    SllNode temp = Head;
                    while(temp.Next.Next != null) temp = temp.Next;
                    SllNode lastNode = temp.Next;
                    temp.Next = null;
                    lastNode = null;
                }
            }
        } 

        public void PrintValues()
        {
            SllNode temp = Head;
            if(temp != null)
            {
                Console.WriteLine("Values of list are: ");
                while(temp != null)
                {
                    Console.Write(temp.Value + " ");
                    temp = temp.Next;
                }
            }
            else Console.WriteLine("The list is empty");

        }  
    }
}