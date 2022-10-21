using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> allNames = new List<string>();
            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int currentCommand = 0; currentCommand < numberOfCommands; currentCommand++)
            {
                string[] command = Console.ReadLine().Split(' ');
                string name = command[0];

                //is going
                if (command.Length == 3)
                {
                    if (allNames.Contains(name))
                        Console.WriteLine($"{name} is already in the list!");
                    else
                        allNames.Add(name);
                }
                // is not going
                else
                {
                    if (!allNames.Contains(name))
                        Console.WriteLine($"{name} is not in the list!");
                    else
                        allNames.Remove(name);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, allNames));
        }
    }
}

