using System;

namespace Poke_Mon
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            uint powerN = uint.Parse(Console.ReadLine());
            uint pokeTargetM = uint.Parse(Console.ReadLine());
            byte exhaustionFactorY = byte.Parse(Console.ReadLine());

            uint currentPower = powerN;
            int countTarget = 0;

            while (currentPower >= pokeTargetM)
            {
                currentPower -= pokeTargetM;
                countTarget++;

                if (currentPower == 0.5 * powerN)
                {
                    if (exhaustionFactorY != 0)
                    {
                        currentPower = (uint)(currentPower / exhaustionFactorY);
                    }
                }
            }

            Console.WriteLine(currentPower);
            Console.WriteLine(countTarget);
        }
    }
}