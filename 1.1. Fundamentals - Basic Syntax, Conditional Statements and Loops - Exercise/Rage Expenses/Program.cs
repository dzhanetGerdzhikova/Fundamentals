using System;

namespace Rage_Expenses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int countLosts = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            int headsetCount = countLosts / 2;
            int mouseCount = countLosts / 3;
            int keyboardCount = countLosts / 6;
            int displayCount = countLosts / 12;

            decimal totalHeadsetPrice = headsetPrice * headsetCount;
            decimal totalMousePrice = mousePrice * mouseCount;
            decimal totalKeyboardPrice = keyboardPrice * keyboardCount;
            decimal totalDisplayPrice = displayPrice * displayCount;

            decimal totalSum = totalHeadsetPrice + totalMousePrice + totalKeyboardPrice + totalDisplayPrice;
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}