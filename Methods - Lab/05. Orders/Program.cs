using System;

namespace _05._Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int numbers = int.Parse(Console.ReadLine());
            

            SumPrice(product, numbers);

        }

        private static void SumPrice(string product, int numbers)
        {


            double price = 0;
            switch (product)
            {

                case "coffee":
                    price = 1.5;
                    break;
                case "water":
                    price = 1;
                    break;
                case "coke":
                    price = 1.4;
                    break;
                case "snacks":
                    price = 2;
                    break;
                default:
                    break;
            }



            Console.WriteLine($"{numbers * price:f2}");
        }
    }
}
