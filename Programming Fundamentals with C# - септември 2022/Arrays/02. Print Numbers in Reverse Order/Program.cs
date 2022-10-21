using System;
using System.Threading.Channels;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
