using System;

namespace Padawan_Equipment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            decimal priceLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceRobes = decimal.Parse(Console.ReadLine());
            decimal priceBelts = decimal.Parse(Console.ReadLine());

            double countSabers = Math.Ceiling(countStudents * 1.10);
            double countsBeltsFree = 0;

            if (countStudents >= 6)
            {
                countsBeltsFree = countStudents / 6;
            }

            decimal totalSabersPrice = decimal.Parse(countSabers.ToString()) * priceLightsabers;
            decimal totalRobesPrice = decimal.Parse(countStudents.ToString()) * priceRobes;
            decimal totalBeltsPrice = (decimal.Parse(countStudents.ToString()) - decimal.Parse(countsBeltsFree.ToString())) * priceBelts;

            decimal moneyForEquipment = totalSabersPrice + totalBeltsPrice + totalRobesPrice;

            if (moneyForEquipment <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyForEquipment:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {moneyForEquipment - money:f2}lv more.");
            }
        }
    }
}