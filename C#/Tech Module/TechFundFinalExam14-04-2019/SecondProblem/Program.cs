using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> notes = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }
                string[] parts = input.Split("->");
                string command = parts[0];
                string store = parts[1];
                switch(command)
                {
                    case "Add":
                        
                        if (parts[2].Contains(","))
                        {
                            
                            List<string> listedItems = parts[2].Split(',').ToList();
                            if (!notes.ContainsKey(store))
                            {
                                notes.Add(store, new List<string>());
                            }
                            
                            foreach (var item in listedItems)
                            {
                                notes[store].Add(item);
                            }
                        }
                        else
                        {
                            if (!notes.ContainsKey(store))
                            {
                                notes.Add(store, new List<string>());
                            }
                            notes[store].Add(parts[2]);
                        }
                        break;
                    case "Remove":
                        if (notes.ContainsKey(store))
                        {
                            notes.Remove(store);
                        }
                        break;
                }
            }
            Console.WriteLine("Stores list:");
            if (notes.Keys.Count > 0)
            {
                foreach (var store in notes.OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Key))
                {
                    Console.WriteLine(store.Key);
                    if (notes[store.Key].Count > 0)
                    {
                        foreach (var item in notes[store.Key])
                        {
                            Console.WriteLine($@"<<{item}>>");
                        }
                    }
                }
            }
            
        }
    }
}
