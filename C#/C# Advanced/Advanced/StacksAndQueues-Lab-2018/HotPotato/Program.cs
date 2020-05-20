using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Queue<string> kids = new Queue<string>(input);
            int move = int.Parse(Console.ReadLine());
            int counter = 1;
            while (kids.Count > 1)
            {
                var currentChild = kids.Dequeue();

                if (counter % move != 0)
                {
                    kids.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }
                counter++;
            }
            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
