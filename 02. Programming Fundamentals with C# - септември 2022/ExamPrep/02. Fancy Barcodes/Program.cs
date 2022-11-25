using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string barcodePatern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            string paternForDigits = @"\d+";
            int n = int.Parse(Console.ReadLine());
            Regex barcodeRegex = new Regex(barcodePatern);
            Regex pGR = new Regex(paternForDigits);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = barcodeRegex.Match(input);
                if (match.Success)
                {

                    MatchCollection pGM = pGR.Matches(match.Value);
                    if (pGM.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("", pGM)}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
