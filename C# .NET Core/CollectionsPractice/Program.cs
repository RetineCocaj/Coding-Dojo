using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[10];
            for(int i = 0; i < intArray.Length; i++){
                intArray[i] = i;
            }

            string[] names = new string[]{"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];
            for(int i = 0; i < boolArray.Length; i++){
                if(i%2 == 0) boolArray[i] = true;
                Console.WriteLine(boolArray[i]);
            }

            List<string> flavors = new List<string>();
            flavors.Add("Strawberry");
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Caramel");
            flavors.Add("Peppermint");

            Console.WriteLine("Number of flavors: " + flavors.Count);
            Console.WriteLine("Third flavour is: " + flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("Actual number of flavors: " + flavors.Count);

            Dictionary<string, string> userInfo = new Dictionary<string, string>();
            Random rand = new Random();
            userInfo.Add(names[0], flavors[rand.Next(0, flavors.Count)]);
            userInfo.Add(names[1], flavors[rand.Next(0, flavors.Count)]);
            userInfo.Add(names[2], flavors[rand.Next(0, flavors.Count)]);
            userInfo.Add(names[3], flavors[rand.Next(0, flavors.Count)]);

            foreach(var user in userInfo){
                Console.WriteLine(user.Key + " " + user.Value);
            }
        }
    }
}
