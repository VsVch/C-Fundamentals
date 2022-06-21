using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNumber(number);
            
        }

        private static void PrintNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDivide8(i) && OddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static bool OddDigit(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    return true;
                    
                }
                number /= 10;
            }
            return false;
        }

        private static bool IsDivide8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
