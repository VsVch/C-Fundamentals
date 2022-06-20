using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            Printriangle(int.Parse(Console.ReadLine()));
                        
        }

        private static void Printriangle(int v)
        {
            for (int i = 1; i <= v; i++)
            {
                PrintLine(1, i);
            }
            for (int i = v - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int first, int second)
        {
            for (int i = first; i <= second; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
