using System;

namespace Triples_of_Latin_Letters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (char letter = 'a'; letter < 'a' + num; letter++)
            {
                for (char secondLetter = 'a'; secondLetter < 'a' + num; secondLetter++)
                {
                    for (char thirdLetter = 'a'; thirdLetter < 'a' + num; thirdLetter++)
                    {
                        Console.WriteLine($"{letter}{secondLetter}{thirdLetter}");
                    }
                }
            }
        }
    }
}