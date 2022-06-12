using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int numbers = 0;
            bool isReal = false;
            for (int i = 1; i <= num; i++)
            {
                numbers = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isReal = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", numbers, isReal);
                sum = 0;
                i = numbers;
            }

        }
    }
}
