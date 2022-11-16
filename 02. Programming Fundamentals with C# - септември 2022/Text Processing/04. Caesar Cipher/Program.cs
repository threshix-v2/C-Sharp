using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (var currChar in input)
            {
                int currPosition = currChar;
                currPosition += 3;
                sb.Append((char)currPosition);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
