using System;
using System.Collections.Generic;

namespace _03._Wild_Zoo
{
    internal static class Program
    {
        static void Main(this string[] args)
        {
            var animals = new Dictionary<string, Animal>();
            var hungryAnimals = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "EndDay")
            {
                var cmdArgs = input.Split(": -");
                var commandType = cmdArgs[0];
                switch (cmdArgs[0])
                {
                    case "Add":
                        HA(animals, cmdArgs[0], int.Parse(cmdArgs[2]), cmdArgs[3], hungryAnimals);
                        break;
                    case "Feed":
                        HF(animals, cmdArgs[1], int.Parse(cmdArgs[2]), hungryAnimals);
                        break;
                }
            }

            Console.WriteLine("Animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value.getFood()}g");
            }
            Console.WriteLine("Areas with hungry animals:");
            foreach (var hungryAnimal in hungryAnimals)
            {
                Console.WriteLine($"{hungryAnimal.Key}: {hungryAnimal.Value}");
            }
        }
        public class Animal
        {
            private string name;
            private int food;
            private string area;

            public Animal(string name, int food, string area)
            {
                this.name = name;
                this.food = food;
                this.area = area;
            }

            public string getName()
            {
                return name;
            }

            public void setName(string name)
            {
                this.name = name;
            }

            public int getFood()
            {
                return food;
            }

            public void setFood(int food)
            {
                this.food = food;
            }

            public String getArea()
            {
                return area;
            }

            public void setArea(string area)
            {
                this.area = area;
            }
        }
        private static void HA(Dictionary<string, Animal> animals, string name, int foodQuantity, string area,
            Dictionary<string, int> hungryAnimals)
        {
            if (!animals.ContainsKey(name))
            {
                Animal animal = new Animal(name, foodQuantity, area);
                animals.Add(name, animal);
            }
            else
            {
                var oFQ = animals[name].getFood();
                animals[name].setFood(foodQuantity + oFQ);
            }

            if (!hungryAnimals.ContainsKey(area))
            {
                hungryAnimals.Add(area, 1);
            }
            else
            {
                var countValue = hungryAnimals[area];
                hungryAnimals.Add(area, countValue + 1);
            }
        }

        private static void HF(Dictionary<string, _03._Wild_Zoo.Program.Animal> animals, string name, int foodQuantity,
            Dictionary<string, int> hungryAnimals)
        {
            _03._Wild_Zoo.Program.Animal animal = animals[name];
            if (animals.ContainsKey(name))
            {
                int foodNeeded = animal.getFood();
                int feedResult = foodNeeded - foodQuantity;
                if (feedResult > 0)
                {
                    animal.setFood(feedResult);
                }
                else
                {
                    Console.WriteLine($"{name} was successfully fed");
                    string livingArea = animal.getArea();
                    int value = hungryAnimals[livingArea];
                    hungryAnimals.Add(livingArea, value - 1);
                    if (hungryAnimals[livingArea] == 0)
                    {
                        hungryAnimals.Remove(livingArea);
                    }
                }
                animals.Remove(name);
            }
        }
    }
}
