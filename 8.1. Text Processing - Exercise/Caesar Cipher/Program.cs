using System;
using System.Text;

namespace Caesar_Cipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                result.Append((char)(input[i] + 3));
            }
            Console.WriteLine(result);
        }
    }
}