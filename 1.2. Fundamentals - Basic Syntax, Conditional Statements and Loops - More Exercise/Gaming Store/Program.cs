using System;

namespace Gaming_Store
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal balance = decimal.Parse(Console.ReadLine());
            string games = Console.ReadLine();

            decimal spent = 0;

            while (games != "Game Time")
            {
                string namegame = "";
                decimal priceGame = 0;

                switch (games)
                {
                    case "OutFall 4":
                        priceGame = 39.99m;
                        namegame = "OutFall 4";
                        break;

                    case "CS: OG":
                        priceGame = 15.99m;
                        namegame = "CS: OG";
                        break;

                    case "Zplinter Zell":
                        priceGame = 19.99m;
                        namegame = "Zplinter Zell";
                        break;

                    case "Honored 2":
                        priceGame = 59.99m;
                        namegame = "Honored 2";
                        break;

                    case "RoverWatch":
                        priceGame = 29.99m;
                        namegame = "RoverWatch";
                        break;

                    case "RoverWatch Origins Edition":
                        priceGame = 39.99m;
                        namegame = "RoverWatch Origins Edition";
                        break;

                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (priceGame != 0)
                {
                    if (balance >= priceGame)
                    {
                        balance -= priceGame;
                        spent += priceGame;
                        Console.WriteLine($"Bought {namegame}");
                    }
                    else if (balance < priceGame)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }

                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                games = Console.ReadLine();
            }

            if (balance > 0)
            {
                Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
            }
        }
    }
}