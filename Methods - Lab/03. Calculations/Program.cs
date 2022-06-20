using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main()
        {

            string command = Console.ReadLine();
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(first, second);
                    break;
                case "multiply":
                    Multiply(first, second);
                    break;
                case "subtract":
                    Substract(first, second);
                    break;
                case "divide":
                    Divide(first, second);
                    break;
                default:
                    break;
            }



        }

        private static void Divide(int first, int second)
        {
            Console.WriteLine(first / second);
        }

        private static void Substract(int first, int second)
        {
            Console.WriteLine(first-second);
        }

        private static void Multiply(int first, int second)
        {
            Console.WriteLine(first*second);
        }

        private static void Add(int first, int second)
        {
            Console.WriteLine(first+second);
        }
    }
}
