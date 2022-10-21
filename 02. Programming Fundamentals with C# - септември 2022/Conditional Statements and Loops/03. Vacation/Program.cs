using System;

namespace _03._Vacation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cntOfPeople = int.Parse(Console.ReadLine());
            var typeOfGroup = Console.ReadLine();
            var dayOfTheWeek = Console.ReadLine();
            double finalPrice = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    if (dayOfTheWeek == "Friday")
                        finalPrice = cntOfPeople * 8.45;
                    else if (dayOfTheWeek == "Saturday")
                        finalPrice = cntOfPeople * 9.80;
                    else if (dayOfTheWeek == "Sunday") finalPrice = cntOfPeople * 10.46;

                    if (cntOfPeople >= 30)
                        finalPrice *= 0.85;
                    break;

                case "Business":
                    if (cntOfPeople >= 100) cntOfPeople -= 10;

                    if (dayOfTheWeek == "Friday")
                        finalPrice = cntOfPeople * 10.90;
                    else if (dayOfTheWeek == "Saturday")
                        finalPrice = cntOfPeople * 15.60;
                    else if (dayOfTheWeek == "Sunday") finalPrice = cntOfPeople * 16;

                    break;

                case "Regular":

                    if (dayOfTheWeek == "Friday")
                        finalPrice = cntOfPeople * 15;
                    else if (dayOfTheWeek == "Saturday")
                        finalPrice = cntOfPeople * 20;
                    else if (dayOfTheWeek == "Sunday") finalPrice = cntOfPeople * 22.50;
                    if (cntOfPeople >= 10 && cntOfPeople <= 20) finalPrice *= 0.95;
                    break;
            }

            Console.WriteLine($"Total price: {finalPrice:f2}");
        }
    }
}