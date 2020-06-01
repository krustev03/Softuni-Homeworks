using Animals.Animal_Types.Cats;
using Animals.Animal_Types.Dogs;
using Animals.Animal_Types.Frogs;
using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
          

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "Beast!")
                {
                    break;
                }

                var input = Console.ReadLine().Split();

                try
                {
                    switch(command)
                    {
                        case "Dog":
                            
                            Dog dog = new Dog(input[0], int.Parse(input[1]), input[2]);
                            animals.Add(dog);
                            break;
                        case "Cat":
                          
                            Cat cat = new Cat(input[0], int.Parse(input[1]), input[2]);
                            animals.Add(cat);
                            break;
                        case "Frog":
                         
                            Frog frog = new Frog(input[0], int.Parse(input[1]), input[2]);
                            animals.Add(frog);
                            break;
                        case "Kitten":

                            Kitten kitten = new Kitten(input[0], int.Parse(input[1]));
                            animals.Add(kitten);
                            break;
                        case "Tomcat":

                            Tomcat tomcat = new Tomcat(input[0], int.Parse(input[1]));
                            animals.Add(tomcat);
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
