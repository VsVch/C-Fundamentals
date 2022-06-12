using System;
using System.Numerics;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            BigInteger population = BigInteger.Parse(Console.ReadLine());
            double area = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {area} square km.");
        }
    }
}
