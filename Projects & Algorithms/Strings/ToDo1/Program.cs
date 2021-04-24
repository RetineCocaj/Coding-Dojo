using System;
using System.Text.RegularExpressions;

namespace ToDo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveBlanks(" Pl ayTha tF u nkyM usi c "));
            Console.WriteLine(GetTheDigits("0s1a3y5w7h9a2t4?6!8?0"));
            Console.WriteLine(Acronyms(" there's no free lunch - gotta pay yer way. "));
            Console.WriteLine(CountNonSpaces("Honey pie, you are driving me crazy"));
            string[] arr = "Honey pie, you are driving me crazy".Split(" ");
            arr = RemoveShorterStrings(arr, 4);
            for(int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

        public static string RemoveBlanks(string str)
        {
            return string.Join("", str.Split(" "));
        }

        public static int GetTheDigits(string str)
        {
            return int.Parse(Regex.Replace(str, "[^0-9.]", ""));
        }

        public static string Acronyms(string str)
        {
            string[] arr = str.Trim().Split(" ");
            for(int i = 0; i < arr.Length; i++)
                arr[i] = arr[i][0].ToString();

            return string.Join("", arr).ToUpper();
        }

        public static int CountNonSpaces(string str)
        {
            int count = 0; 
            for(int i = 0; i < str.Length; i++)
                if(str[i] != ' ') count++;
            return count;
        }

        public static string[] RemoveShorterStrings(string[] arr, int len)
        {   
            int countShorter = 0;
            for(int i = 0; i < arr.Length; i++)
                if(arr[i].Length < len)
                    countShorter++;

            string[] newArr = new string[arr.Length - countShorter];
            int index = 0;
            for(int i = 0; i < arr.Length; i++)
                if(!(arr[i].Length < len))
                    newArr[index++] = arr[i];

            return newArr;
        }
    }
}
