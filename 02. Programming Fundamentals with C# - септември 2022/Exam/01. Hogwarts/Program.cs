using System;

namespace _01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string spellName = Console.ReadLine();
            string command;
            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                var cmdArgs = command.Split(String.Empty, StringSplitOptions.RemoveEmptyEntries);
                var cmdType = cmdArgs[0];
                switch (cmdType)
                {
                    case "Abjuration":
                        spellName = spellName.ToUpper();
                        Console.WriteLine(spellName);
                        break;
                    case "Necromancy":
                        spellName = spellName.ToLower();
                        Console.WriteLine(spellName);
                        break;
                    case "Illusion":
                        var index = int.Parse(cmdArgs[1]);
                        var letter = cmdArgs[2];
                        if (spellName.Length > index)
                        {
                            spellName = spellName.Remove(index, 1);
                            spellName = spellName.Insert(index, letter);
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        var firstSubstring = cmdArgs[1];
                        var secondSubstring = cmdArgs[2];
                        if (spellName.Contains(firstSubstring))
                        {
                            spellName = spellName.Replace(firstSubstring, secondSubstring);
                        }
                        break;
                    case "Alteration":
                        var substring = cmdArgs[1];
                        if (spellName.Contains(substring))
                        {
                            spellName = spellName.Replace(substring, String.Empty);
                            Console.WriteLine(spellName);
                        }
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}
