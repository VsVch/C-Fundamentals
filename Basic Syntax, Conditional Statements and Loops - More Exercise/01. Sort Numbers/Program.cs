using System;

namespace _01._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine(first);
                if (second > third)
                {
                    Console.WriteLine(second);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(second);
                }
            }
            if (second > third && second > first)
            {
                Console.WriteLine(second);
                if (third > first)
                {
                    Console.WriteLine(third);
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                }
            }
            if (third > first && third > second)
            {
                Console.WriteLine(third);
                if (first > second)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(second);
                }
                else
                {
                    Console.WriteLine(second);
                    Console.WriteLine(first);
                }
            }




        }
    }
}
