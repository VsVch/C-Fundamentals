using System;
using System.Linq;

namespace _07.IdenticalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var arr = input;
            var reverse = arr.Reverse();
            Console.WriteLine(string.Join(" ", arr.Reverse()));






        }
    }
}