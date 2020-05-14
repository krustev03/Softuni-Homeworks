using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parking = new Dictionary<string, string>();
            for (int i = 1; i <= n; i++)
            {
                string[] parts = Console.ReadLine().Split().ToArray();
                string command = parts[0];
                string username = string.Empty;
                switch (command)
                {
                    case "register":
                        
                        username = parts[1];
                        string plateNumber = parts[2];
                        if (!parking.ContainsKey(username))
                        {
                            parking.Add(username, plateNumber);
                            Console.WriteLine($"{username} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                        }
                        break;
                    case "unregister":
                        username = parts[1];
                        if (parking.ContainsKey(username))
                        {
                            parking.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        break;
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
