using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplicationTable = new int[10, 10];
            for(int i = 0; i < multiplicationTable.GetLength(0); i++){
                Console.Write("[");
                for(int j = 0; j < multiplicationTable.GetLength(1); j++){
                    multiplicationTable[i, j] = (i+1)*(j+1);
                    
                    if(multiplicationTable[i, j] < 10) Console.Write($"  {multiplicationTable[i, j]}, ");
                    else if(multiplicationTable[i, j] >= 10 && multiplicationTable[i, j] < 100) Console.Write($" {multiplicationTable[i, j]}, ");
                    else Console.Write($"{multiplicationTable[i, j]}, ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
