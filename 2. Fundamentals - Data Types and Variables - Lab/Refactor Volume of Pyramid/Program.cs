using System;

namespace Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height) / 3.0;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}