using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());
            int th = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            int sumFirstSecond = first + sec;
            int divideThSum = sumFirstSecond / th;
            int multiply = four * divideThSum;

            Console.WriteLine(multiply);





        }
    }
}
