using System;

namespace Centuries_to_Minutes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double daysOfYear = 365.2422;

            int years = input * 100;
            double days = Math.Floor(years * daysOfYear);
            double hours = days * 24;
            double minutes = hours * 60;
            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}