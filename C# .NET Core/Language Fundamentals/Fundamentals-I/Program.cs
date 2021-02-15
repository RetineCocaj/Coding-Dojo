using System;

namespace Fundamentals_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing numbers 1-255");
            for(int i = 1; i <= 255; i++){
                Console.Write(i + ", ");
            }

            Console.WriteLine("\n\nPrinting numbers 1-100 divisible by 3 or 5");
            for(int i = 1; i <= 100; i++){
                if(i%3 == 0 || i%5 == 0){
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine("\n\nMultipliers of 3 - Fizz, Multipliers of 5 - Buzz, Multipliers of 3 and 5 - FizzBuzz");
            for(int i = 1; i <= 100; i++){
                if(i%3 == 0 && i%5 ==0){
                    Console.Write(i + " FizzBuzz, ");
                    continue;
                }
                else if(i%3 == 0){
                    Console.Write(i + " Fizz, ");
                }
                else if(i%5 == 0){
                    Console.Write(i + " Buzz, ");
                }
            }

            Console.WriteLine("\n\n\n-----SAME PRINTINGS WITH WHILE LOOP------");

            Console.WriteLine("\n\nPrinting numbers 1-255");
            int j = 1;
            while(j <= 255){
                Console.Write(j + ", ");
                j++;
            }

            Console.WriteLine("\n\nPrinting numbers 1-100 divisible by 3 or 5");
            j = 1;
            while(j <= 100){
                if(j%3 == 0 || j%5 == 0){
                    Console.Write(j + ", ");
                }
                j++;
            }

            Console.WriteLine("\n\nMultipliers of 3 - Fizz, Multipliers of 5 - Buzz, Multipliers of 3 and 5 - FizzBuzz");
            j = 1;
            while(j <= 100){
                if(j%3 == 0 && j%5 ==0){
                    Console.Write(j + " FizzBuzz, ");
                    j++;
                    continue;
                }
                else if(j%3 == 0){
                    Console.Write(j + " Fizz, ");
                }
                else if(j%5 == 0){
                    Console.Write(j + " Buzz, ");
                }
                j++;
            }
        }
    }
}
