using System;
using System.Numerics;

namespace Snowballs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            checked
            {
                byte numberOfSnowballs = byte.Parse(Console.ReadLine());

                BigInteger highest = int.MinValue;

                ushort highestSnowballSnow = 0;
                ushort highestSnowballTime = 0;
                ushort highestSnowballQuality = 0;

                for (byte currentNumberOfSnowballs = 1; currentNumberOfSnowballs <= numberOfSnowballs; currentNumberOfSnowballs++)
                {
                    ushort snowballSnow = ushort.Parse(Console.ReadLine());
                    ushort snowballTime = ushort.Parse(Console.ReadLine());
                    ushort snowballQuality = ushort.Parse(Console.ReadLine());

                    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                    if (snowballValue > highest)
                    {
                        highest = snowballValue;

                        highestSnowballSnow = snowballSnow;
                        highestSnowballTime = snowballTime;
                        highestSnowballQuality = snowballQuality;
                    }
                }
                Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highest} ({highestSnowballQuality})");
            }
        }
    }
}