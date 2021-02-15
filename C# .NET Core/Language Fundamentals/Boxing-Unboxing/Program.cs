using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> obj = new List<object>();
            obj.Add(7);
            obj.Add(28);
            obj.Add(-1);
            obj.Add(true);
            obj.Add("chair");

            Console.Write("Objects: ");
            foreach(var o in obj){
                Console.Write(o + " ");
            }

            int sum = 0;
            foreach(var o in obj){
                if(o is int){
                    sum += (int)o;
                }
            }
            Console.WriteLine($"\nSum of integers: {sum}" );
        }
    }
}
