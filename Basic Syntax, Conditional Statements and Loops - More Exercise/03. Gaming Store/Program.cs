using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            double spendMoney = currentBalance;

            string input = Console.ReadLine();
            double priceOneGame = 0;

            while (input != "Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                        priceOneGame = 39.99;
                        break;
                    case "CS: OG":
                        priceOneGame = 15.99;
                        break;
                    case "Zplinter Zell":
                        priceOneGame = 19.99;
                        break;
                    case "Honored 2":
                        priceOneGame = 59.99;
                        break;
                    case "RoverWatch":
                        priceOneGame = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        priceOneGame = 39.99;
                        break;
                    default:
                        Console.WriteLine($"Not Found");
                        break;
                }
                currentBalance -= priceOneGame;
                if (currentBalance < 0)
                {
                    Console.WriteLine($"Too Expensive");
                    currentBalance += priceOneGame;
                }
                else
                if (currentBalance == 0)
                {
                    Console.WriteLine($"Out of money!");
                }
                else
                {
                    Console.WriteLine($"Bought {input}");
                }


                input = Console.ReadLine();
            }

            if (input == "Game Time")
            {
                Console.WriteLine($"Total spent: ${(spendMoney - currentBalance):f2}. Remaining: ${currentBalance:f2}");
            }
        }
    }
}
