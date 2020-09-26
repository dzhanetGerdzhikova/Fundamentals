using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MatchCollection coolThresholdSum = Regex.Matches(input, @"[0-9]");
            BigInteger threshold = 1;
            foreach (Match digit in coolThresholdSum)
            {
                threshold *= int.Parse(digit.Value);
            }

            MatchCollection emojis = Regex.Matches(input, @"(\*{2}|:{2})(?<name>[A-Z][a-z]{2,})(\1)");
            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");
            foreach (Match match in emojis)
            {
                BigInteger currentThreshold = 0;
                string currentEmoji = match.Groups["name"].Value;

                for (int i = 0; i < currentEmoji.Length; i++)
                {
                    currentThreshold += (int)currentEmoji[i];
                }
                if (currentThreshold > threshold)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}