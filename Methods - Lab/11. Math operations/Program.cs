using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = RaiseToPower(number, sign, power);
            Console.WriteLine(result);

        }


        private static double RaiseToPower(double number, char sign, double power)
        {
            double result = 0;
            switch (sign)
            {

                case '+':
                    result = number + power;
                    break;
                case '-':
                    result = number - power;
                    break;
                case '*':
                    result = number * power;
                    break;
                case '/':
                    result = number /power;
                    break;
                default:
                    break;
            }
            return result;

        }
    }
}
