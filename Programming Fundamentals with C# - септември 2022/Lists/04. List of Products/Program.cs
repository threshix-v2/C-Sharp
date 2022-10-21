using System;
using System.Collections.Generic;
using System.Reflection;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> listOfProducts = new List<string>();
            for (int i = 0; i < n; i++)
                listOfProducts.Add(Console.ReadLine());
            listOfProducts.Sort();

            for (int i = 0; i < n; i++)
                Console.WriteLine($"{i + 1}.{listOfProducts[i]}");

            //int counter = 1;
            //foreach (string product in listOfProducts)
            //{
            //    Console.WriteLine($"{counter}.{product}");
            //    counter++;
            //}
        }
    }
}
