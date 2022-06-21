using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double firstFacturiel = Facturiel(first);
            double secondFacturiel = Facturiel(second);
            double result = Devide(firstFacturiel, secondFacturiel);
            Console.WriteLine($"{result:f2}");
        }

        private static double Devide(double firstFacturiel, double secondFacturiel)
        {
            double result = firstFacturiel / secondFacturiel;
            return result;
        }

        private static double Facturiel(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;

        }
    }
}
