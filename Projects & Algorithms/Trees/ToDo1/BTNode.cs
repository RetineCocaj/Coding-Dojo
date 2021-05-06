namespace ToDo1
{
    public class BTNode
    {
        public BTNode Left;
        public BTNode Right;
        public int Value;

        public BTNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}