using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            Console.WriteLine();

            TossMultipleCoins(8);
            Console.WriteLine();

            List<string> names = Names();
            foreach(var n in names) Console.Write($"{n} ");
        }
        public static int[] RandomArray()
        {
            int[] randArr = new int[10];
            Random rand = new Random();
            for(int i = 0; i < randArr.Length; i++){
                randArr[i] = rand.Next(5, 25);
            }
            int min = randArr[0];
            int max = min;
            int sum = max;
            for(int i = 1; i < randArr.Length; i++)
            {
                if(max < randArr[i]) max = randArr[i];
                if(min > randArr[i]) min = randArr[i];
                sum += randArr[i];
            }
            foreach(int num in randArr) Console.Write($"{num} ");
            Console.WriteLine($"\nMax: {max}, Min: {min}, Sum: {sum}");
            return randArr;
        }

        public static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
            int cointoss = rand.Next(2);
            string result = "";
            if(cointoss == 0) result = "Heads";
            else result = "Tails";
            Console.WriteLine($"It's a {result}!");

            return result;
        }

        public static double TossMultipleCoins(int num)
        {   
            int countHeads = 0;
            int i = 0; 
            while(i < num)
            {
                string toss = TossCoin();
                if(toss == "Heads") countHeads++;
                i++;
            }
            double ratio = (double)countHeads/num;
            Console.WriteLine($"The ratio of head tosses ({countHeads}) to total number of tosses ({num}) is {ratio}");

            return ratio;
        }

        public static List<string> Names()
        {
            List<string> names = new List<string>{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};

            Random rand = new Random();
            for(int i = 0; i < names.Count/2; i++)
            {
                int rndIndex = rand.Next(names.Count);
                string temp = names[rndIndex];
                names[rndIndex] = names[i];
                names[i] = temp;
            }

            foreach(var name in names) Console.Write($"{name} ");
            Console.WriteLine();
            
            for(int i = 0; i < names.Count; i++)
                if(names[i].Length <= 5) names.RemoveAt(i);

            return names;
        }
    }
}
