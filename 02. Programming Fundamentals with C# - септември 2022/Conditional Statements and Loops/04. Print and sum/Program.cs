using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string blankspace = " ";
            int sum = 0;
            int firsDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());

            for (int currentNumber = firsDigit; currentNumber <= secondDigit; currentNumber++)
            {

                Console.Write(currentNumber + blankspace);
                sum += currentNumber;            
                
            }            
            Console.WriteLine(sum);

        }
    }
}
