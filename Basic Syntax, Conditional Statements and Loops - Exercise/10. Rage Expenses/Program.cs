using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeybord = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboad = lostGames / 6;
            int trashedDisplay = lostGames / 12;

            double sum = priceHeadset * trashedHeadset + priceMouse * trashedMouse + priceKeybord * trashedKeyboad + priceDisplay * trashedDisplay;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");




        }
    }
}
