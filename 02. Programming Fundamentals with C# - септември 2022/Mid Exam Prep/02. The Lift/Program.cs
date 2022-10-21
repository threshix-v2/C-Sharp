using System;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            int[] lift = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            {
                while (lift[i] < 4 && people > 0)
                    if (lift[i] < 4)
                        lift[i]++;
            }

            if (people == 0 && lift.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0 && lift.Any(x => x == 4))
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            else
                Console.WriteLine(string.Join(" ", lift));

        }
    }
}