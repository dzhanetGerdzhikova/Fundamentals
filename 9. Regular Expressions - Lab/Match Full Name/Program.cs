using System;
using System.Text.RegularExpressions;

namespace Match_Full_Name
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Regex regExpr = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            string text = Console.ReadLine();

            var result = regExpr.Matches(text);

            foreach (Match match in result)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}