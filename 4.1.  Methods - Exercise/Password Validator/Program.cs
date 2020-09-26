using System;

namespace Password_Validator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (AreCharactersInclusive(password) && HasOnlyLettersAndDigits(password) && HasTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (!AreCharactersInclusive(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!HasOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!HasTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        private static bool AreCharactersInclusive(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool HasOnlyLettersAndDigits(string password)
        {
            bool isValidChar = true;

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 0 && password[i] < 9 || (int)password[i] >= 65 && (int)password[i] <= 122 || password[i] >= 48 && password[i] <= 57)
                {
                    continue;
                }
                else
                {
                    isValidChar = false;
                }
            }

            if (isValidChar)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool HasTwoDigits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    count++;
                }
            }
            if (count < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}