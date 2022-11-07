using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource;
            Dictionary<string, int> allResources = new Dictionary<string, int>();
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!allResources.ContainsKey(resource))
                {
                    allResources[resource] = 0;
                }
                allResources[resource] += quantity;
            }

            foreach (var c in allResources)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
