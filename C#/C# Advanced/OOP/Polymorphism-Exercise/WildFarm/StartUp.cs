using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Animals.Birds;
using WildFarm.Animals.Mammals;
using WildFarm.Animals.Mammals.Felines;
using WildFarm.Foods;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                var animalArgs = Console.ReadLine().Split();

                if (animalArgs[0] == "End")
                {
                    break;
                }

                var foodArgs = Console.ReadLine().Split();

                var animal = CreateAnimal(animalArgs);
                animals.Add(animal);
                var food = CreateFood(foodArgs);

                animal.Eat(food);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        public static Food CreateFood(string[] foodArgs)
        {
            int quantity = int.Parse(foodArgs[1]);

            switch (foodArgs[0])
            {
                case "Vegetable":
                    Vegetable vegetable = new Vegetable(quantity);
                    return vegetable;
                case "Fruit":
                    Fruit fruit = new Fruit(quantity);
                    return fruit;
                case "Meat":
                    Meat meat = new Meat(quantity);
                    return meat;
                case "Seeds":
                    Seeds seeds = new Seeds(quantity);
                    return seeds;
                default:
                    return null;
            }
        }

        public static Animal CreateAnimal(string[] args)
        {
            switch(args[0])
            {
                case "Hen":
                    Hen hen = new Hen(args[1], double.Parse(args[2]), double.Parse(args[3]));
                    return hen;
                case "Owl":
                    Owl owl = new Owl(args[1], double.Parse(args[2]), double.Parse(args[3]));
                    return owl;
                case "Dog":
                    Dog dog = new Dog(args[1], double.Parse(args[2]), args[3]);
                    return dog;
                case "Mouse":
                    Mouse mouse = new Mouse(args[1], double.Parse(args[2]), args[3]);
                    return mouse;
                case "Cat":
                    Cat cat = new Cat(args[1], double.Parse(args[2]), args[3], args[4]);
                    return cat;
                case "Tiger":
                    Tiger tiger = new Tiger(args[1], double.Parse(args[2]), args[3], args[4]);
                    return tiger;
                default:
                    return null;
            }
        }
    }
}
