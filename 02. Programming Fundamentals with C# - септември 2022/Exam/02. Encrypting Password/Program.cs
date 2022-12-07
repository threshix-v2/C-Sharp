using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<smb>.+)>(?<nms>\d{3})\|(?<lwr>[a-z]{3})\|(?<upr>[A-Z]{3})\|(?<test>[^<>]{3})<\k<smb>";
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            string invalidPassword = "Try another password!";
            for (int i = 0; i < n; i++)
            {
                string newInput = Console.ReadLine();
                if (Regex.IsMatch(newInput, pattern))
                {
                    Match match = Regex.Match(newInput, pattern);
                    string currentPassword = "Password: " + match.Groups["nms"].Value + match.Groups["lwr"].Value + match.Groups["upr"].Value + match.Groups["test"].Value;
                    list.Add(currentPassword);
                }
                else
                    list.Add(invalidPassword);
            }
            Console.WriteLine(string.Join(Environment.NewLine, list));
        }
    }
}