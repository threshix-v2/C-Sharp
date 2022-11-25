using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] commandInfo = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];

                switch (command)
                {
                    case "InsertSpace":
                        int index = int.Parse(commandInfo[1]);
                        message = message.Insert(index, " ");
                        Console.WriteLine(message);
                        break;
                    case "Reverse":
                        string substring = commandInfo[1];
                        int startIndex = message.IndexOf(substring);
                        if (message.Contains(substring))
                        {
                            if (startIndex != -1)
                            {
                                message = message.Remove(startIndex, substring.Length);
                                message += string.Join("", substring.Reverse());
                            }

                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        Console.WriteLine(message);
                        break;
                    case "ChangeAll":
                        string replacement = commandInfo[2];
                        message = message.Replace(commandInfo[1], replacement);
                        Console.WriteLine(message);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
