using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            GetStringSum(input[0], input[1]);
        }

        private static void GetStringSum(string v1, string v2)
        {
            int sum = 0;
            int minLenght = Math.Min(v1.Length, v2.Length);
            for (int i = 0; i < minLenght; i++)
            {
                sum += v1[i] * v2[i];
            }
            string longestLenghtString = v1;
            if (longestLenghtString.Length < v2.Length)
            {
                longestLenghtString = v2;
            }
            for (int i = minLenght; i < longestLenghtString.Length; i++)
            {
                sum += longestLenghtString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
