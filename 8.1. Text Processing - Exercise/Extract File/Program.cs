using System;

namespace Extract_File
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string[] lastSplitedText = input[input.Length - 1].Split('.');

            Console.WriteLine($"File name: {lastSplitedText[0]}");
            Console.WriteLine($"File extension: {lastSplitedText[1]}");
        }
    }
}