using System;

namespace Vacation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string typeDay = Console.ReadLine();

            decimal price = 0;

            switch (typeRoom)
            {
                case "Students":
                    switch (typeDay)
                    {
                        case "Friday":
                            price = 8.45m;
                            break;

                        case "Saturday":
                            price = 9.80m;
                            break;

                        case "Sunday":
                            price = 10.46m;
                            break;

                        default:
                            break;
                    }
                    if (people >= 30)
                    {
                        price *= 0.85m;
                    }
                    break;

                case "Business":
                    switch (typeDay)
                    {
                        case "Friday":
                            price = 10.90m;
                            break;

                        case "Saturday":
                            price = 15.60m;
                            break;

                        case "Sunday":
                            price = 16m;
                            break;

                        default:
                            break;
                    }
                    if (people >= 100)
                    {
                        people -= 10;
                    }
                    break;

                case "Regular":
                    switch (typeDay)
                    {
                        case "Friday":
                            price = 15;
                            break;

                        case "Saturday":
                            price = 20;
                            break;

                        case "Sunday":
                            price = 22.50m;
                            break;

                        default:
                            break;
                    }
                    if (people >= 10 && people <= 20)
                    {
                        price *= 0.95m;
                    }

                    break;

                default:
                    break;
            }
            if (price > 0)
            {
                Console.WriteLine($"Total price: {people * price:f2}");
            }
        }
    }
}