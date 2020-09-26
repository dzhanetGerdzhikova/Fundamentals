using System;

namespace Repeat_String
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countRepeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, countRepeat));
        }

        private static string RepeatString(string input, int countRepeat)
        {
            string firstInput = "";
            for (int i = 0; i < countRepeat; i++)
            {
                firstInput += input;
            }
            return firstInput;
        }
    }
}