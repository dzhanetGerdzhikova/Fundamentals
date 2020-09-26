using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input != "end of shift")
            {
                Match match = Regex.Match(input, @"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<quantity>[0-9]+)\|[^|$%.]*?(?<price>[0-9]+.?[0-9]*)\$");
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double totalPrice = quantity * price;
                    totalIncome += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}