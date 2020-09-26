using System;

namespace Convert_Meters_to_Kilometers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int inputInMeters = int.Parse(Console.ReadLine());

            decimal convertToKilometers = inputInMeters / 1000.0M;

            Console.WriteLine($"{convertToKilometers:f2}");
        }
    }
}