using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();
            double totalMoneySpend = 0;
            string patern = @"^>>(?<furnitureName>[A-Za-z]+)<<(?<price>\d+(\.\d+){0,1})!(?<quantity>\d+)(\.\d+){0,1}$";
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(inputLine, patern);
                if (match.Success)
                {
                    string furnitureName = match.Groups["furnitureName"].Value;
                    double pricePerUnit = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furniture.Add(furnitureName);
                    totalMoneySpend += pricePerUnit * quantity;
                }
            }
            Console.WriteLine($"Bought furniture:");
            foreach (var furnitureName in furniture)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
