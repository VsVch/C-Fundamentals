using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int curCap = 255;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int lit = int.Parse(Console.ReadLine());
                curCap -= lit;
                sum += lit;
                if (curCap < 0)
                {
                    curCap += lit;
                    sum -= lit;
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);
        }
    }
}
