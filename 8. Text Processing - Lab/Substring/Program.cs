using System;

namespace Substring
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string input = Console.ReadLine();

            string result = "";

            //while (input.Contains(word))
            //{
            //    result = input.Replace(word, string.Empty);
            //    input = result;
            //}
            //Console.WriteLine(result);

            while (input.IndexOf(word) > -1)
            {
                int index = input.IndexOf(word);
                result = input.Remove(index, word.Length);
                input = result;
            }
            Console.WriteLine(input);
        }
    }
}