using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            int position = 0;
            int end = houses.Count - 1;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Merry Xmas!")
                {
                    break;
                }
                string[] part = command.Split().ToArray();
                int jumps = int.Parse(part[1]);
                if (position + jumps > end)
                {
                    jumps = (jumps + position) % houses.Count;
                    position = jumps;
                }
                else
                {
                    position = position + jumps;
                }
                if (houses[position] <= 0)
                {
                    Console.WriteLine($"House {position} will have a Merry Christmas.");
                }
                else
                {
                    houses[position] -= 2;
                }
                
            }
            int k = 0;
            for (int i = 0; i < houses.Count; i++)
            {
                if (houses[i] <= 0)
                {
                    k++;
                }
            }
            Console.WriteLine($"Santa's last position was {position}.");
            if (k == houses.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Santa has failed {houses.Count - k} houses.");
            }
        }
    }
}
