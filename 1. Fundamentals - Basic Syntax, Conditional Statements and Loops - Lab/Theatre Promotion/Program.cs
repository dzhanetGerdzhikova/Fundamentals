using System;

namespace Theatre_Promotion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0;
            switch (typeOfDay)
            {
                case "Weekday":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    break;

                case "Weekend":
                    if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    break;

                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    break;

                default:
                    break;
            }

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}