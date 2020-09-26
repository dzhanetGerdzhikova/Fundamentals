using System;

namespace Sum_of_Chars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countOfLetters = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int currentLetter = 1; currentLetter <= countOfLetters; currentLetter++)
            {
                char letter = char.Parse(Console.ReadLine());

                sum += (int)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}