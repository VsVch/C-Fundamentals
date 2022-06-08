using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coinsForGoods = Console.ReadLine();
            double corectCoins = 0;
            double sum = 0;
            
            while (coinsForGoods != "Start")
            {
                corectCoins = double.Parse(coinsForGoods);
                
                if ((corectCoins != 0.1) && (corectCoins != 0.2) && (corectCoins != 0.5) && (corectCoins != 1) && (corectCoins!= 2))    
                {
                    
                    Console.WriteLine($"Cannot accept {corectCoins}");
                   
                    
                }
                else
                {
                    sum += corectCoins;
                    


                }
                coinsForGoods = Console.ReadLine();

            }
            if (coinsForGoods == "Start")
            {

                
                string goods = Console.ReadLine();
                while (goods != "End")
                {
                   
                    
                    switch (goods)
                    {
                        case "Nuts":
                            sum -= 2;
                            if (sum < 0)
                            {
                                Console.WriteLine($"Sorry, not enough money");
                                sum += 2;

                            }
                            else
                            {
                                Console.WriteLine($"Purchased nuts");
                            }
                            
                            break;
                        case "Water":
                            sum -= 0.7;
                            if (sum < 0)
                            {
                                Console.WriteLine($"Sorry, not enough money");
                                sum += 0.7;

                            }
                            else
                            {
                                Console.WriteLine($"Purchased water");
                            }

                            
                            break;
                        case "Crisps":
                            sum -= 1.5;
                            if (sum < 0)
                            {
                                Console.WriteLine($"Sorry, not enough money");
                                sum += 1;

                            }
                            else
                            {
                                Console.WriteLine($"Purchased crisps");
                            }

                            
                            break;
                        case "Soda":
                            sum -= 0.8;
                            if (sum < 0)
                            {
                                Console.WriteLine($"Sorry, not enough money");
                                sum += 0.8;

                            }
                            else
                            {
                                Console.WriteLine($"Purchased soda");
                            }

                            
                            break;
                        case "Coke":
                            sum -= 1;
                            if (sum < 0)
                            {
                                Console.WriteLine($"Sorry, not enough money");
                                sum += 1;

                            }
                            else
                            {
                                Console.WriteLine($"Purchased coke");
                            }
                            
                            break;

                        default:
                            Console.WriteLine($"Invalid product");
                            break;
                    }
                    
                    goods = Console.ReadLine();
                }
                if (goods == "End")
                {
                    Console.WriteLine($"Change: {sum:f2}");
                }
            }

        }
    }
}

