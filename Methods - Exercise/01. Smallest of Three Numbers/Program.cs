using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            PrintSmallest(first, second, third);
        }

        private static void PrintSmallest(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                Console.WriteLine(first);
            }
            else if (second < first && second < third)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(third);
            }
            
        }
    }
}
