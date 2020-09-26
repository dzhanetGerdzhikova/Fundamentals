using System;

namespace Text_Filter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                text = text.Replace(words[i], new String('*', words[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}