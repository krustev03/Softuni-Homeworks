using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Lumpawaroo")
                {
                    break;
                }
                if (command.Contains("->"))
                {
                    string[] parts = command.Split(" -> ");
                    string user = parts[0];
                    string side = parts[1];
                    int k = 0;
                    foreach (var item in forces)
                    {
                        foreach (var human in forces[item.Key])
                        {
                            if (user == human)
                            {
                                k = 1;
                                forces[item.Key].Remove(human);
                                break;
                            }
                        }
                    }
                    if (k == 0)
                    {
                        if (!forces.ContainsKey(side))
                        {
                            forces.Add(side, new List<string>() );
                        }
                        forces[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        if (!forces.ContainsKey(side))
                        {
                            forces.Add(side, new List<string>());
                        }
                        forces[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                if (command.Contains("|"))
                {
                    string[] parts = command.Split(" | ");
                    string user = parts[1];
                    string side = parts[0];
                    int k = 0;
                    foreach (var item in forces)
                    {
                        foreach (var human in forces[item.Key])
                        {
                            if (user == human)
                            {
                                k = 1;
                            }
                        }
                    }
                    if (!forces.ContainsKey(side))
                    {
                        forces.Add(side, new List<string>());
                        if (k == 0)
                        {
                            forces[side].Add(user);
                        }
                    }
                    else
                    {
                        if (k == 0)
                        {
                            forces[side].Add(user);
                        }
                    }
                }
            }
            foreach (var item in forces.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (item.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count}");
                    List<string> names = forces[item.Key];
                    names.Sort();
                    foreach (var human in names)
                    {
                        Console.WriteLine($"! {human}");
                    }
                }
                
            }
        }
    }
}
