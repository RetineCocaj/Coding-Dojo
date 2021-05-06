using System;

namespace ToDo1
{
    public class BST
    {
        public BTNode Root;
        public int size;
        public BST()
        {
            Root = null;
            size = 0;
        }

        public BTNode Add(int value)
        {
            if (Root != null)
            {
                BTNode runner = Root;
                while (runner != null)
                {
                    if (value > runner.Value)
                    {
                        if (runner.Right != null) runner = runner.Right;
                        else
                        {
                            runner.Right = new BTNode(value);
                            return runner.Right;
                        }
                    }
                    else
                    {
                        if (runner.Left != null) runner = runner.Left;
                        else
                        {
                            runner.Left = new BTNode(value);
                            return runner.Left;
                        }
                    }
                }
            }
            Root = new BTNode(value);
            return Root;
        }

        public bool Contains(int value)
        {
            BTNode runner = Root;
            while (runner != null)
            {
                if (value == runner.Value) return true;
                if (value < runner.Value)
                {
                    if (runner.Left == null) return false;
                    runner = runner.Left;
                }
                else
                {
                    if (runner.Right == null) return false;
                    runner = runner.Right;
                }
            }
            return false;
        }

        public int Min()
        {
            BTNode runner = Root;
            int min = Root.Value;
            while (runner.Left != null)
            {
                if (runner.Left.Value < min) min = runner.Left.Value;
                runner = runner.Left;
            }
            return min;
        }

        public int Max()
        {
            BTNode runner = Root;
            int max = Root.Value;
            while (runner.Right != null)
            {
                if (runner.Right.Value > max) max = runner.Right.Value;
                runner = runner.Right;
            }
            return max;
        }

        // public int Size(BTNode tree)
        // {
        //     if(tree != null) size++;
        //     if(tree.Left != null) {
        //         size++;
        //         Size(tree.Left);
        //     }
        //     if(tree.Right != null)
        //     {
        //         size++;
        //         Size(tree.Right);
        //     }
        //     return size;
        // }

        public int Size()
        {
            BTNode runner = Root;
            if (runner == null) return 0;
            return SizeHelper(runner);
        }

        public int SizeHelper(BTNode node)
        {
            if(node == null) return 0;
            return 1 + SizeHelper(node.Left) + SizeHelper(node.Right);
        }

        public bool IsEmpty()
        {
            if(Root == null) return true;
            return false;
        }


        public void Display(BTNode tree)
        {
            if (tree != null)
            {
                Console.WriteLine("{0}" + (new String(' ', 2)), tree.Value);
                Display(tree.Left);
                Display(tree.Right);
            }
        }
    }
}