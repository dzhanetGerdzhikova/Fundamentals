using System;

namespace Calculate_Rectangle_Area
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(AreaOfRectangle(width, height));
        }

        private static double AreaOfRectangle(double width, double height)
        {
            double result = width * height;
            return result;
        }
    }
}