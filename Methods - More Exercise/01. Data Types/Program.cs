using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            if (input == "int")
            {
                int num = int.Parse(Console.ReadLine());
                num = Sum(num);
                Console.WriteLine(num);
               
                
                
            }
            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                num = Sum2(num);
                Console.WriteLine($"{num:f2}");
            }
            else if (input == "string")
            {
                string inp = Console.ReadLine();
                Console.WriteLine($"${inp}$");
            }

        }

        private static double Sum2(double num)
        {
            double sum2 = num * 1.5; return sum2;
        }

        private static int Sum(int num)
        { int sum = num * 2;    return sum;  }

    }
}