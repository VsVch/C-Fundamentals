using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(String.Join(" ", SumPairs(list)));
        }

        static List<int> SumPairs(List<int> numbers)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - i - 1]);
            }

            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            return result;
        }


    }
}