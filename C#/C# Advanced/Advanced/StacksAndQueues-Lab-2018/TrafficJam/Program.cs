using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int canPass = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> cars = new Queue<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }
                else if (input == "green")
                {
                    for (int i = 0; i < canPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
        }
    }
}
