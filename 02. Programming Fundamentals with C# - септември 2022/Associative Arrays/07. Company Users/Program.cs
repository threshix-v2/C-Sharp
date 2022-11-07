using System;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companyDictionary = new Dictionary<string, List<string>>();
        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] cmdArgs = command.Split(" -> ");
            string companyName = cmdArgs[0];
            string id = cmdArgs[1];
            if (!companyDictionary.ContainsKey(companyName))
                companyDictionary.Add(companyName, new List<string>());
            if (!companyDictionary[companyName].Contains(id))
                companyDictionary[companyName].Add(id);
        }

        foreach (var company in companyDictionary)
        {
            Console.WriteLine(company.Key);
            foreach (var employee in company.Value)
            {
                Console.WriteLine($"-- {employee}");
            }
        }
    }
}