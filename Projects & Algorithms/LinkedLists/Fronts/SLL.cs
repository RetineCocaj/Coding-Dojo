using System;

namespace Fronts
{
    public class SLL
    {
        public Node Head;
        public SLL() 
        {
            Head = null;
        }

        public Node AddFront(int value) 
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
            return Head;
        }

        public Node RemoveFront()
        {
            if(Head != null)
            {
                Head = Head.Next;
            }
            return Head;
        }

        public int? Front()
        {
            if(Head != null)
            {
                return Head.Value;
            }
            return null;
        }

        public bool Contains(int val)
        {
            Node runner = Head;
            while(runner != null)
            {
                if(runner.Value == val) return true;
                runner = runner.Next;
            }
            return false;
        }

        public int Length()
        {
            Node runner = Head;
            int countNodes = 0;
            while(runner != null)
            {
                countNodes++;
                runner = runner.Next;
            }
            return countNodes;
        }

        public void PrintValues()
        {
            Node temp = Head;
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