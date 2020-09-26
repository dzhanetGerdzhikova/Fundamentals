using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < countInput; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, @"@#+(?<group>[A-Z][A-Za-z\d]{4,}[A-Z])@#+");
                if (match.Success)
                {
                    MatchCollection productGroup = Regex.Matches(match.Groups["group"].Value, @"\d");
                    StringBuilder result = new StringBuilder();
                    if (productGroup.Count > 0)
                    {
                        //foreach (Match num in productGroup)
                        //{
                        //    result.Append(num);
                        //}
                        //Console.WriteLine($"Product group: {result}");
                        Console.WriteLine($"Product group: {string.Concat(productGroup.Select(e => e.Value))}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}