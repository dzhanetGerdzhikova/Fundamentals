using System;

namespace Characters_in_Range
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            CharactersinRange(first, second);
        }

        private static void CharactersinRange(char one, char two)
        {
            if (one < two)
            {
                for (int i = one + 1; i < two; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = two + 1; i < one; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}