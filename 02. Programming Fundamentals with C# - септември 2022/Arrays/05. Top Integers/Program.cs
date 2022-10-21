﻿using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                bool isTopInteger = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextElement = numbers[j];
                    if (nextElement >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}
