using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var result = num * 1.31;
            Console.WriteLine($"{result:f3}");
        }
    }
}
