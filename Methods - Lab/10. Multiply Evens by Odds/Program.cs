using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenDigitSum = GetDigitsSum(number, 0);
            int oddDigitSum = GetDigitsSum(number, 1);

            Console.WriteLine(evenDigitSum * oddDigitSum);

        }


        static int GetDigitsSum(int number, int evenOddCheck)
        {
            int sum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == evenOddCheck)
                {
                    sum += digit;
                }

                number /= 10;
            }

            return sum;
        }
    }
}
