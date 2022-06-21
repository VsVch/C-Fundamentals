using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int firstResult = Add(first, second);
            int secondResult = Subtrack(firstResult, third);
            Console.WriteLine(secondResult);
        }

        private static int Subtrack(int firstResult, int third)
        {
            int secondResult = firstResult - third;
            return secondResult;
        }

        private static int Add(int first, int second)
        {
            int firstResult = first + second;
            return firstResult;
        }
    }
}
