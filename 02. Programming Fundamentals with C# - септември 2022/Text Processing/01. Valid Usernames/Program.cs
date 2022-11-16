using System;
using System.Runtime.Intrinsics.Arm;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            foreach (var currName in usernames)
            {
                if (currName.Length > 3 && currName.Length <= 16)
                {
                    bool isValid = true;
                    foreach (var currChar in currName)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(currName);
                        
                    }
                }
            }
        }
    }
}
