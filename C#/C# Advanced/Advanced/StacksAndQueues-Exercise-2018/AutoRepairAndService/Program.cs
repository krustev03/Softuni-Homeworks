using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> carsList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            Queue<string> cars = new Queue<string>(carsList);
            Stack<string> history = new Stack<string>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                var parts = command.Split("-");
                switch(parts[0])
                {
                    case "Service":
                        if (cars.Any() == true)
                        {
                            history.Push(cars.Peek());
                            Console.WriteLine($"Vehicle {cars.Dequeue()} got served.");
                        }
                        break;
                    case "CarInfo":
                        string carName = parts[1];
                        if (cars.Contains(carName))
                        {
                            Console.WriteLine("Still waiting for service.") ;
                        }
                        else
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case "History":
                        string[] copy = history.ToArray();
                        for (int i = 0; i < copy.Length; i++)
                        {
                            if (i == copy.Length - 1)
                            {
                                Console.WriteLine(copy[i]);
                            }
                            else
                            {
                                Console.Write(copy[i] + ", ");
                            }
                        }
                        break;
                }
            }


            
            if (cars.Any() == true)
            {
                Console.Write("Vehicles for service: ");
                List<string> waiting = cars.ToList();
                for (int i = 0; i < waiting.Count; i++)
                {
                    if (i == waiting.Count - 1)
                    {
                        Console.WriteLine(waiting[i]);
                    }
                    else
                    {
                        Console.Write(waiting[i] + ", ");
                    }
                }
            }
            if (history.Any() == true)
            {
                Console.Write("Served vehicles: ");
                List<string> served = history.ToList();
                for (int i = 0; i < served.Count; i++)
                {
                    if (i == served.Count - 1)
                    {
                        Console.WriteLine(served[i]);
                    }
                    else
                    {
                        Console.Write(served[i] + ", ");
                    }
                }
            }
        }
    }
}
