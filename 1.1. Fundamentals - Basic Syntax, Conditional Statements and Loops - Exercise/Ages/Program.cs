using System;

namespace Ages
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (input <= 13)
            {
                Console.WriteLine("child");
            }
            else if (input <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (input <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}