using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            min += 30;
            if (min >= 60)
            {
                min = min - 60;
                hours = hours + 1;
                if (hours >=24)
                {
                    hours = hours - 24;
                }
            }
            Console.WriteLine($"{hours}:{min:d2}");
        }
    }
}
