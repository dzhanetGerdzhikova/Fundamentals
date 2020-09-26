using System;

namespace Login
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string newPassword = "";

            for (int i = password.Length - 1; i >= 0; i--)
            {
                newPassword += password[i];
            }

            string name = Console.ReadLine();

            int countIncorectLodIn = 0;

            while (name != newPassword)
            {
                countIncorectLodIn++;
                if (countIncorectLodIn == 4)
                {
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                name = Console.ReadLine();
            }

            if (name == newPassword)
            {
                Console.WriteLine($"User {password} logged in.");
            }
            else if (countIncorectLodIn == 4)
            {
                Console.WriteLine($"User {password} blocked!");
            }
        }
    }
}