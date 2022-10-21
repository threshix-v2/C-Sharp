using System;
namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peoples = new int[numberOfWagons];
            int totalPeoples = 0;

            for (int currentWagon = 0; currentWagon <= numberOfWagons-1; currentWagon++)
            {
                peoples[currentWagon] = int.Parse(Console.ReadLine());
                totalPeoples += peoples[currentWagon];
            }
            Console.WriteLine(string.Join(" ", peoples));
            Console.WriteLine(totalPeoples);
        }
    }
}
