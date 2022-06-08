using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceForCoffee = 0;
            double pricePerCapsule = 0;
            int days = 0;
            int capsulesCount = 0;
            double total = 0;

            for (int i = 0; i < n; i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulesCount = int.Parse(Console.ReadLine());

                priceForCoffee = ((days * capsulesCount) * pricePerCapsule);

                total += priceForCoffee;
                Console.WriteLine($"The price for the coffee is: ${priceForCoffee:f2}");


            }
            total = total;
            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
