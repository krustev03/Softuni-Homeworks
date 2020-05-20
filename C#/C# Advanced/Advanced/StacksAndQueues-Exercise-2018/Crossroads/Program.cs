using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            bool allSafe = true;
            int count = 0;
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                else if (command == "green")
                {
                    if (cars.Any() == true)
                    {
                        Queue<char> crossroad = new Queue<char>();
                        Queue<char> car = new Queue<char>();
                        string name = cars.Peek();
                        foreach (var symbol in cars.Dequeue())
                        {
                            car.Enqueue(symbol);
                        }
                        if (greenLight > 0)
                        {
                            for (int i = 1; i <= greenLight; i++)
                            {
                                if (car.Any() == true)
                                {
                                    if (car.Count == 1)
                                    {
                                        count++;
                                    }
                                    crossroad.Enqueue(car.Dequeue());
                                }
                                else
                                {
                                    
                                    crossroad.Clear();
                              
                                    if (cars.Any() == true)
                                    {
                                        name = cars.Peek();
                                        foreach (var symbol in cars.Dequeue())
                                        {
                                            car.Enqueue(symbol);
                                        }
                                        crossroad.Enqueue(car.Dequeue());
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            if (crossroad.Any() == true)
                            {
                                for (int i = 1; i <= freeWindow; i++)
                                {
                                    if (car.Any() == true)
                                    {
                                        if (car.Count == 1)
                                        {
                                            count++;
                                        }
                                        crossroad.Enqueue(car.Dequeue());
                                    }
                                }
                            }
                            if (car.Any() == true)
                            {
                                allSafe = false;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{name} was hit at {car.Peek()}.");
                                break;
                            }

                        }
                    }
                    
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            if (allSafe)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }
        }
    }
}
