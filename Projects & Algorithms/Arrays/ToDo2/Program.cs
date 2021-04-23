using System;

namespace ToDo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            PrintArr(arr);
            PrintArr(Reverse(arr));
            PrintArr(Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7}, -3));
            PrintArr(Filter(new int[] { 1, 2, 3, 4, 5, 6, 7}, 2, 5));
            object[] concat = Concat(new object[] {12, 24, 36}, new object[]{"Retina", "Cocaj", "2"});
            for(int i = 0; i < concat.Length; i++) Console.Write(concat[i] + " ");
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] Reverse(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }

        public static int[] Rotate(int[] arr, int shiftBy)
        {
            int rot = Math.Abs(shiftBy);
            for (int i = 0; i < rot; i++)
            {
                if (shiftBy > 0)
                {
                    int temp = arr[arr.Length-1];
                    for (int j = arr.Length-1; j > 0; j--)
                        arr[j] = arr[j - 1];
                    arr[0] = temp;
                }
                else 
                {
                    int temp = arr[0];
                    for (int j = 0; j < arr.Length - 1; j++)
                        arr[j] = arr[j + 1];
                    arr[arr.Length - 1] = temp;
                }
            }
            return arr;
        }

        public static int[] Filter(int[] arr, int min, int max)
        {
            int countElements = 0;
            for(int i = 0; i < arr.Length; i++)
                if(arr[i] > min && arr[i] < max) countElements++;

            int[] newArr = new int[countElements];
            int index = 0;
            for(int j = 0; j < arr.Length; j++)
                if(arr[j] > min && arr[j] < max)
                    newArr[index++] = arr[j];

            return newArr;
        }

        public static object[] Concat(object[] obj1, object[] obj2)
        {
            object[] resultobj = new object[obj1.Length + obj2.Length];
            for(int i = 0; i < resultobj.Length; i++)
            {
                if(i < obj1.Length) resultobj[i] = obj1[i];
                else resultobj[i] = obj2[i - obj1.Length];
            }
            return resultobj;
        }
    }
}
