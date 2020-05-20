using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    break;
                }
                else if (command == "Paid")
                {
                    int count = names.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                    
                }
                else
                {
                    names.Enqueue(command);
                }
            }
        }
    }
}
