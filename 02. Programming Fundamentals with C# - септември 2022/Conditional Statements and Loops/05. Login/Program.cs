using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char currCh = username[i];
                password += currCh;
            }
            int attempts = 0;
            string enteredPassword;
            while ((enteredPassword = Console.ReadLine()) != password)
            {
                attempts++;
                if (attempts >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
return;
                }
                else
                    Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {username} logged in.");

        }
    }
}
