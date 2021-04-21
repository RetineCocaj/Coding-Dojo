using System;

namespace MinToFront
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {8,5,2,4,7,1,3};
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int[] newArr = MinToFront(arr);
            for(int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }

        public static int[] MinToFront(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if(min > arr[i]) min = arr[i];
            }

            int[] newArr = new int[arr.Length];
            newArr[0] = min;
            for (int i = 1; i < newArr.Length; i++)
            {
                if(arr[i-1] == min) newArr[i] = arr[i];
                else newArr[i] = arr[i-1];
            }
            return newArr;
        }
    }
}
