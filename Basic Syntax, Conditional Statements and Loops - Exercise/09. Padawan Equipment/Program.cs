using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double priceLightSabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double pricebelts = double.Parse(Console.ReadLine());
            int freeBelt = 0;
            freeBelt = student / 6;
           // Console.WriteLine(freeBelt);

            double sum = 0;
            
            sum = priceLightSabers * (Math.Ceiling(student + student * 0.1)) + priceRobes * student + pricebelts * (student - freeBelt);

            if (amountMoney >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(sum-amountMoney):f2}lv more.");
            }

        }
    }
}
