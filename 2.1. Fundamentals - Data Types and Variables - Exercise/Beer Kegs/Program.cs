using System;

namespace Beer_Kegs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countKegs = int.Parse(Console.ReadLine());

            double max = double.MinValue;
            string name = "";
            for (int currentKeg = 1; currentKeg <= countKegs; currentKeg++)
            {
                string modelOfKeg = Console.ReadLine();
                float radiusOfKeg = float.Parse(Console.ReadLine());
                int hightOfKeg = int.Parse(Console.ReadLine());

                double volume = Math.PI * radiusOfKeg * radiusOfKeg * hightOfKeg;

                if (volume > max)
                {
                    max = volume;
                    name = modelOfKeg;
                }
            }
            Console.WriteLine($"{name}");
        }
    }
}