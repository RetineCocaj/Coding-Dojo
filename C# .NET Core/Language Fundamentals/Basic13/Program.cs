using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {   
            PrintNumbers();

            PrintOdds();

            PrintSum();

            int[] arr = new int[]{1,2,8,-6,7,3,-1,23, -17,0};
            LoopArray(arr);

            Console.WriteLine($"\nMax value of array is {FindMax(arr)}");

            GetAverage(arr);

            int[] odds = OddArray();
            Console.WriteLine("\nPrinting Odd Array");
            foreach(int o in odds) Console.Write($"{o} ");

            int y = 5;
            Console.WriteLine($"\n\n{GreaterThanY(arr, y)} numbers are greater than {y} in array");

            SquareArrayValues(arr);

            arr = new int[]{1,2,8,-6,7,3,-1,23, -17,0};
            EleminateNegatives(arr);

            MinMaxAverage(arr);

            ShiftValues(new int[]{1, 5, 10, 7, -2});

            object[] obj = NumToString(new int[]{1, -5, 10, 7, -2});
            Console.WriteLine("\nNegative numbers to string ");
            foreach(object o in obj) Console.Write($"{o} ");

            Console.WriteLine();

        }

        public static void PrintNumbers()
        {
            Console.WriteLine("\nPrinting 1-255");
            for(int i = 1; i <= 255; i++)
                Console.Write($"{i} ");
                
            Console.WriteLine();
        }

        public static void PrintOdds()
        {
            Console.WriteLine("\nPrinting odds 1-255");
            for(int i = 1; i <= 255; i++)
                if(i%2 == 1) Console.Write($"{i} ");

            Console.WriteLine();
        }

        public static void PrintSum()
        {
            Console.WriteLine("\nPrinting sums");
            int sum = 0; 
            for(int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            Console.WriteLine("\nIterating through array");
            foreach(int num in numbers)
                Console.Write(num + " ");

            Console.WriteLine();
        }

        public static int FindMax(int[] numbers)
        {
            int max = numbers[0];
            for(int i = 1; i < numbers.Length; i++)
                if(max < numbers[i]) max = numbers[i];

            return max;
        }

        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++)
                sum += numbers[i];

            sum /= numbers.Length;
            Console.WriteLine($"\nAverage of array is {sum}");
        }

        public static int[] OddArray(){
            int[] odds = new int[255/2 + 1];
            int index = 0;
            for(int i = 1; i <= 255; i++)
                if(i%2 == 1) odds[index++] = i;

            return odds;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
                if(numbers[i] > y) count++;

            return count;
        }

        public static void SquareArrayValues(int[] numbers){
            Console.WriteLine("\nPrinting Squared Values of array");
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }

        public static void EleminateNegatives(int[] numbers)
        {
            Console.WriteLine("\nEleminating Negatives");
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0) numbers[i] = 0;
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = max;
            int sum = max;

            for(int i = 1; i < numbers.Length; i++)
            {
                if(max < numbers[i]) max = numbers[i];
                if(min > numbers[i]) min = numbers[i];
                sum += numbers[i];
            }
            sum /= numbers.Length;
            Console.WriteLine($"\nMax number of array is {max} ");
            Console.WriteLine($"Min number of array is {min} ");
            Console.WriteLine($"Average of array values is {sum} ");
        }

        public static void ShiftValues(int[] numbers)
        {   
            Console.Write ("\nShifting values ");
            foreach(int num in numbers) Console.Write($"{num} ");
            Console.Write(" => ");

            for(int i = 0; i < numbers.Length-1; i++)
                numbers[i] = numbers[i+1];

            numbers[numbers.Length-1] = 0;
            
            foreach(int num in numbers) Console.Write($"{num} ");
            Console.WriteLine();
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] obj = new object[numbers.Length];
            for(int i = 0; i < obj.Length; i++)
            {
                if(numbers[i] < 0) obj[i] = "Dojo";
                else obj[i] = numbers[i];
            }
            return obj;
        }
    }
}
