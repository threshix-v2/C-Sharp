﻿using System;
using System.Linq;
namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            int timesToRotate = rotationsCount % arr.Length;

            for (int r = 1; r <= timesToRotate; r++)
            {
                int firstEl = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstEl;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
