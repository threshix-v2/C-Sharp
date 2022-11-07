using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArg = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmdArg[0];
                string studentName = cmdArg[1];


                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();
                }
                coursesInfo[courseName].Add(studentName);
            }

            foreach (var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                List<string> studentsList = kvp.Value;
                Console.WriteLine($"{courseName}: {studentsList.Count}");
                foreach (var studentName in studentsList)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
