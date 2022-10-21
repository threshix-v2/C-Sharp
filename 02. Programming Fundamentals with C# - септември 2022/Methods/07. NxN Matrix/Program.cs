using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printMatrix(n);
        }

        private static void printMatrix(int fill)
        {
            for (int i = 0; i < fill; i++)
            {
                for (int j = 0; j < fill; j++)
                {
                   Console.Write(fill + " "); 
                }
                Console.WriteLine();
            }
        }
    }
}
