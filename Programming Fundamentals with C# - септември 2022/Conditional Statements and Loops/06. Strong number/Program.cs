using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorialSum = 0;
            int n = int.Parse(Console.ReadLine());
            int numCopy = n;
            while (numCopy > 0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;
                int factorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                factorialSum += factorial;
            }
            if (factorialSum == n)
            {
                Console.WriteLine("yes");
            }
            else
                Console.WriteLine("no");
        }
    }
}
