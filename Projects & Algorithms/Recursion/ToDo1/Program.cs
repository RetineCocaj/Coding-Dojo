using System;

namespace ToDo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sigma(2.5));
            Console.WriteLine(Factorial(6.5));

        }

        public static double Sigma(double value)
        {
            value = Math.Floor(value);
            if(value < 0) return 0;
            if(value == 0) return value;
            return value + Sigma(value - 1);
        }

        public static double Factorial(double value)
        {
            value = Math.Floor(value);
            if(value <= 0) return 1;
            return value * Factorial(value - 1);
        }
    }
}
