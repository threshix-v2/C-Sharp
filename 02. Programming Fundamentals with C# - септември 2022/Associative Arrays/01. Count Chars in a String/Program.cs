using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = Console.ReadLine().Where(c => c != ' ').ToArray();
            Dictionary<char, int> charOccurance = new Dictionary<char, int>();
            foreach (var c in chars)
            {
                if (!charOccurance.ContainsKey(c))
                {
                    charOccurance.Add(c, 0);

                }

                charOccurance[c]++;
            }

            foreach (var c in charOccurance)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
