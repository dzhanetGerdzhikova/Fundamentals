using System;

namespace Back_In_30_Minutes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 30;

            if (minutes > 59)
            {
                hour++;

                if (hour > 23)
                {
                    hour -= 24;
                }
                minutes %= 60;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}