using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            Console.WriteLine(secondMethod(first, second, third));
        }

        static int firstMethod(int first, int second)
        {
            int sum = 0;
            sum = first + second;
            return sum;
        }
        static int secondMethod(int first, int second, int third)
        {
            int sum = 0;
            sum = firstMethod(first, second) - third;
            return sum;
        }
    }
}
