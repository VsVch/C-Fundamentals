using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal BP = decimal.Parse(Console.ReadLine());
            decimal kof = (decimal)1.31;
            decimal dollares = BP * kof;

            Console.WriteLine($"{dollares:f3}");

        }
    }
}
