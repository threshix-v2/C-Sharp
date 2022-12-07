using System;
using System.Text;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var activationKey = new StringBuilder(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] arguments = command.Split(">>>");
                var cmdType = arguments[0];
                if (cmdType == "Contains")
                {
                    string substring = arguments[1];
                    if (activationKey.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (cmdType == "Flip")
                {
                    var flipType = arguments[1];
                    var startIndex = int.Parse(arguments[2]);
                    var endIndex = int.Parse(arguments[3]);
                    var substring = activationKey.ToString().Substring(startIndex, endIndex - startIndex);
                    if (flipType == "Upper")
                    {
                        activationKey.Replace(substring, substring.ToUpper());
                        Console.WriteLine(activationKey);
                    }

                    else if (flipType == "Lower")
                    {
                        activationKey.Replace(substring, substring.ToLower());
                        Console.WriteLine(activationKey);
                    }
                }

                if (cmdType == "Slice")
                {
                    var startIndex = int.Parse(arguments[1]);
                    var endIndex = int.Parse(arguments[2]);
                    activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }

            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
