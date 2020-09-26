using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Furniture
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();

            while (input != "Purchase")
            {
                text.Append(input);

                input = Console.ReadLine();
            }

            var result = Regex.Matches(text.ToString(), @">>(?<name>\w+)+<<(?<price>[0-9]+\.?[0-9]*)!(?<quantity>[0-9]+)");

            double totalPrice = 0;
            Console.WriteLine("Bought furniture:");

            foreach (Match match in result)
            {
                string name = match.Groups["name"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                double quantity = double.Parse(match.Groups["quantity"].Value);

                totalPrice += price * quantity;
                Console.WriteLine(name);
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}