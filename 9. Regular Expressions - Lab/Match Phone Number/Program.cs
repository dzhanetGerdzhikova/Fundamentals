using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Match_Phone_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Regex regExpr = new Regex(@" ?\+359( |-)2(\1)(\d{3})(\1)(\d{4})\b");
            string text = Console.ReadLine();

            var result = regExpr.Matches(text);

            Console.WriteLine(string.Join(",", result.Select(x => x.Value)));
        }
    }
}