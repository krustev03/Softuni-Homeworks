using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BigInteger> resources = new Dictionary<string, BigInteger>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "stop")
                {
                    break;
                }
                string resource = command;
                BigInteger quantity = BigInteger.Parse(Console.ReadLine());
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
