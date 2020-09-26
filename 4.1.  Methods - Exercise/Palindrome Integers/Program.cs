using System;

namespace Palindrome_Integers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string number = Console.ReadLine();

            while (number != "END")
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                number = Console.ReadLine();
            }
            static bool IsPalindrome(string number)
            {
                for (int i = 0; i < number.Length / 2; i++)
                {
                    if (number[i] == number[number.Length - 1 - i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}