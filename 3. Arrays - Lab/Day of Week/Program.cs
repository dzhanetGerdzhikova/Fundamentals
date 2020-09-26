using System;

namespace Day_of_Week
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            //string[] days = new string[7];

            //days[0] = "Monday";
            //days[1] = "Tuesday";
            //days[2] = "Wednesday";
            //days[3] = "Thursday";
            //days[4] = "Friday";
            //days[5] = "Saturday";
            //days[6] = "Sunday";

            string[] days =
                {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
                 };
            if (num < 1 || num > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[num - 1]);
            }
        }
    }
}