using System;

namespace LinkedLists
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
            if (Head != null)
            {
                Head = Head.Next;
            }
            return Head;
        }

        public int? Front()
        {
            if (Head != null)
            {
                return Head.Value;
            }
            return null;
        }

        public bool Contains(int val)
        {
            Node runner = Head;
            while (runner != null)
            {
                if (runner.Value == val) return true;
                runner = runner.Next;
            }
            return false;
        }

        public int Length()
        {
            Node runner = Head;
            int countNodes = 0;
            while (runner != null)
            {
                countNodes++;
                runner = runner.Next;
            }
            return countNodes;
        }

        public string Display()
        {
            var output = "";
            Node temp = Head;
            while (temp != null)
            {
                output += temp.Value + " ";
                temp = temp.Next;
            }
            return output;
        }

        public int Max()
        {
            Node runner = Head;
            int max = runner.Value;
            while(runner != null)
            {
                if(runner.Value > max) max = runner.Value;
                runner = runner.Next;
            }
            return max;
        }

        public int Min()
        {
            Node runner = Head;
            int min = runner.Value;
            while(runner != null)
            {
                if(runner.Value < min) min = runner.Value;
                runner = runner.Next;
            }
            return min;
        }

        public double Average()
        {
            Node runner = Head;
            double sum = 0;
            while(runner != null)
            {
                sum += runner.Value;
                runner = runner.Next;
            }
            return sum/Length();
        }
    }
}