using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(", ");
            string input;
            var participants = new Dictionary<string, int>();
            for (int i = 0; i < line.Length; i++)
                participants.Add(line[i], 0);
            string paternForName = @"(?<name>[A-Za-z]+)";
            string paternForDigits = @"(?<digits>[\d])";
            while ((input = Console.ReadLine()) != "end of the race")
            {
                string name = string.Empty;
                MatchCollection matchesName = Regex.Matches(input, paternForName);
                foreach (Match symbol in matchesName)
                {
                    name += symbol.Value;
                }
                int distance = 0;
                MatchCollection matchDistance = Regex.Matches(input, paternForDigits);
                foreach (Match symbol in matchDistance)
                {
                    distance += int.Parse(symbol.Value);
                }
                if (participants.ContainsKey(name))
                    participants[name] += distance;

                input = Console.ReadLine();
            }

            participants = participants.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int place = 1;
            string[] places = new string[] { "st", "nd", "rd" };
            foreach (var person in participants.Take(3))
            {
                Console.WriteLine($"{place}{places[place - 1]} place: {person.Key}");
                place++;
            }
        }
    }
}