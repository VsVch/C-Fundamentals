using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintVowels(input);
        }

        private static void PrintVowels(string input)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char ch in input)
            {
                if (vowels.Contains(ch.ToString().ToLower().ToCharArray()[0]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
