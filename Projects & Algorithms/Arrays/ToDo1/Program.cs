using System;

namespace ToDo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 8, 3, 4, 5, 1, 6, 8, 9 };
            int value = 4;
            int index = 3;
            Console.WriteLine("For array");
            PrintArr(arr);

            Console.WriteLine("Push Front with value " + value);
            PrintArr(PushFront(arr, value));

            Console.WriteLine("Pop Front");
            Console.WriteLine(PopFront(arr));
            Console.WriteLine();

            Console.WriteLine("Insert value " + value + " at index " + index);
            PrintArr(InsertAt(arr, index, value));

            Console.WriteLine("Remove at index " + index);
            Console.WriteLine(RemoveAt(arr, index));
            Console.WriteLine();

            Console.WriteLine("Swap Pairs");
            PrintArr(SwapPairs(arr));

            Console.WriteLine("Remove Duplicates");
            var array = RemoveDuplicates(arr);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int[] PushFront(int[] arr, int val)
        {
            int[] newArr = new int[arr.Length + 1];
            newArr[0] = val;
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i + 1] = arr[i];
            }
            return newArr;
        }

        public static int PopFront(int[] arr)
        {
            int[] newArr = new int[arr.Length - 1];
            int value = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                newArr[i - 1] = arr[i];
            }
            return value;
        }

        public static int[] InsertAt(int[] arr, int index, int val)
        {
            int[] newArr = new int[arr.Length + 1];
            if (!(index >= newArr.Length || index < 0))
            {
                newArr[index] = val;
                for (int i = 0; i < newArr.Length; i++)
                {
                    if (i < index) newArr[i] = arr[i];
                    else if (i == index) newArr[i] = val;
                    else newArr[i] = arr[i - 1];
                }
                return newArr;
            }
            return arr;
        }

        public static int? RemoveAt(int[] arr, int index)
        {
            int[] newArr = new int[arr.Length - 1];
            int? val = null;
            if (!(index >= newArr.Length || index < 0))
            {
                for (int i = 0; i < newArr.Length; i++)
                {
                    if (i < index) newArr[i] = arr[i];
                    else
                    {
                        if (i == index) val = arr[i];
                        newArr[i] = arr[i + 1];
                    }
                }
            }
            return val;
        }

        public static int[] SwapPairs(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (i != arr.Length - 1)
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
                else continue;
            }
            return arr;
        }

        public static int?[] RemoveDuplicates(int[] arr)
        {
            int?[] newArr = new int?[arr.Length];
            for(int i = 0; i < arr.Length; i++) newArr[i] = arr[i];
            
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(newArr[i] == arr[j])
                    {
                        newArr[j] = null;
                    }
                }
            }
            int countNulls = 0;
            for(int i = 0; i < newArr.Length; i++) 
                if(newArr[i] == null) countNulls++;
            
            int?[] returnArr = new int?[newArr.Length - countNulls];
            int index = 0;
            for(int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == null) continue;
                else returnArr[index++] = newArr[i];
            }
            return returnArr;
        }
    }
}
