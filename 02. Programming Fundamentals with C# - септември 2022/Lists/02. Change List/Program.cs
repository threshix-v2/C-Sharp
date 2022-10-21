using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> allNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<string> input = Console.ReadLine()
              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .ToList();


            /// · Delete {element} – delete all elements in the array, which are equal to the given element.
            ///· Insert {element}{position} – insert the element at the given position

            while (input[0] != "end")
            {
                string command = input[0];
                string element = input[1];

                if (command == "Delete")
                {
                    DeleteAllFromList(allNumbers, int.Parse(element));
                }
                else if (command == "Insert")
                    allNumbers.Insert(int.Parse(input[2]), int.Parse(element));
                input = Console.ReadLine()
                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                .ToList();
            }
            Console.WriteLine(string.Join(" ", allNumbers));
        }

        private static void DeleteAllFromList(List<int> allNumbers, int element)
        {
            List<int> filteredList = new List<int>();
            for (int currentNumber = 0; currentNumber < allNumbers.Count - 1; currentNumber++)
            {
                if (!(currentNumber == element))
                {
                    filteredList.Add(currentNumber);
                }
            }
            Print(filteredList);

            return;
        }

        private static void Print(List<int> filteredList)
        {
            for (int i = 0; i <= filteredList.Count; i++)
            {
                Console.Write(filteredList);
                Console.Write(string.Empty);
            }
        }
    }
}


