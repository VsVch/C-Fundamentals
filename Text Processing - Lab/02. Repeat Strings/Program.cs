using System;
using System.Linq;

namespace _01.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initial = Console.ReadLine().Split();
            string result = string.Empty;
            foreach (var word in initial)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }

            }
            Console.WriteLine(result);



        }
    }
}