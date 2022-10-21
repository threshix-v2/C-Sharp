using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLenghtValid = isPasswordLenghtValid(password);
            bool isPasswordAlphaNumeric = Program.isPasswordAlphaNumeric(password);
            bool hasTwoDigits = isPasswordContainingTwoDigits(password);

            if (!isLenghtValid)
                Console.WriteLine("Password must be between 6 and 10 characters");
            if (!isPasswordAlphaNumeric)
                Console.WriteLine("Password must consist only of letters and digits");
            if (!hasTwoDigits)
                Console.WriteLine("Password must have at least 2 digits");
            if (isLenghtValid && isPasswordAlphaNumeric && hasTwoDigits)
                Console.WriteLine("Password is valid");
        }

        static bool isPasswordLenghtValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool isPasswordAlphaNumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool isPasswordContainingTwoDigits(string password)
        {
            int digitsCnt = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitsCnt++;
                }
            }

            return digitsCnt >= 2;
        }
    }
}
