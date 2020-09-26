using System;

namespace Middle_Characters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleCharacters(input);
        }

        private static void MiddleCharacters(string input)
        {
            int result = 0;

            if (input.Length % 2 == 0)
            {
                result = input.Length / 2;
                for (int i = result - 1; i <= result; i++)
                {
                    Console.Write(input.ToString()[i].ToString());
                }
            }
            else
            {
                result = (input.Length - 1) / 2;
                Console.WriteLine(input[result]);
            }
        }
    }
}