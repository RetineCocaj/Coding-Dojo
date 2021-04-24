using System;

namespace ToDo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(rBinarySearch(new int[]{4,5,6,8,12},5));
            Console.WriteLine(rGCF(123456,987654));

        }


        public static bool rBinarySearch(int[] arr, int value)
        {
            int l = 0;
            int r = arr.Length-1;
            int[] newArr;

            if(r >= l && l <= arr.Length-1)
            {
                int mid = (l+r)/2;
                if(arr[mid] == value) return true;
                if(arr[mid] > value) 
                {
                    newArr = new int[mid-l+1];
                    Array.ConstrainedCopy(arr, l, newArr, 0, mid);
                    return rBinarySearch(newArr, value);
                }
                newArr = new int[r - mid]; //2-1=1
                Array.ConstrainedCopy(arr, mid+1, newArr, 0, r-mid);
                return rBinarySearch(newArr, value);
            }
            return false;
        }

        public static int rGCF(int a, int b)
        {
            if(a == b || a == 0) return b;
            return rGCF(b%a, a);
        }
    }
}
