using System;
using System.Globalization;

namespace _1.Day_of_Week
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime day = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(day.DayOfWeek);
        }
    }
}