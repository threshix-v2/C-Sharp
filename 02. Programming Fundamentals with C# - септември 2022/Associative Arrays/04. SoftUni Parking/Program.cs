using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> RegisteredCars = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string cmdType = input[0];
                string username = input[1];

                if (cmdType == "register")
                {
                    string licensePlate = input[2];
                    if (!RegisteredCars.ContainsKey(username))
                    {
                        RegisteredCars.Add(username, licensePlate);
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                    else
                    {
                        string licensePlateNumber = RegisteredCars[username];
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }

                else if (cmdType == "unregister")
                {
                    if (!RegisteredCars.ContainsKey(username)) 
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        RegisteredCars.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var VARIABLE in RegisteredCars)
            {
                Console.WriteLine($"{VARIABLE.Key} => {VARIABLE.Value}");
            }
        }
    }
}
