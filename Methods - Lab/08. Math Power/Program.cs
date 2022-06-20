using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Power(a, b);
        }

        private static void Power(double a, double b)
        {
            double sum = 1;

            for (int i = 0; i < b; i++)
            {
                sum *= a ;
                
            }

            Console.WriteLine(sum);
        }
    }
}
