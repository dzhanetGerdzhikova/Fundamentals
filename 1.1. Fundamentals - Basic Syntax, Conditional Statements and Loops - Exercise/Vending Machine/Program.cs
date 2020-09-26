using System;

namespace Vending_Machine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string coins = Console.ReadLine();

            decimal sumCoins = 0;

            while (coins != "Start")
            {
                decimal convertCoinc = decimal.Parse(coins);
                if (convertCoinc == 0.1m || convertCoinc == 0.2m || convertCoinc == 0.5m || convertCoinc == 1 || convertCoinc == 2)
                {
                    sumCoins += convertCoinc;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                coins = Console.ReadLine();
            }

            string product = Console.ReadLine();
            decimal price = 0;
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        price = 2;
                        break;

                    case "Water":
                        price = 0.7m;
                        break;

                    case "Crisps":
                        price = 1.5m;
                        break;

                    case "Soda":
                        price = 0.8m;
                        break;

                    case "Coke":
                        price = 1;
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (price != 0)
                {
                    if (sumCoins >= price)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        sumCoins -= price;
                    }
                    else if (sumCoins < price)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sumCoins:f2}");
        }
    }
}