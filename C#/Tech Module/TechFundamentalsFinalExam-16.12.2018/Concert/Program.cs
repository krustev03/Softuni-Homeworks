using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BigInteger> bandTime = new Dictionary<string, BigInteger>();
            Dictionary<string, List<string>> bandMembers = new Dictionary<string, List<string>>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "start of concert")
                {
                    
                    break;
                }
                string[] parts = command.Split("; ");
                string bandName = string.Empty;
                switch(parts[0])
                {
                    case "Add":
                        bandName = parts[1];
                        if (!bandTime.ContainsKey(bandName))
                        {
                            bandMembers.Add(bandName, new List<string>());
                            string[] members = parts[2].Split(", ");
                            for (int i = 0; i < members.Length; i++)
                            {
                                if (!bandMembers[bandName].Contains(members[i]))
                                {
                                    bandMembers[bandName].Add(members[i]);
                                }
                            }
                            
                            bandTime.Add(bandName, 0);
                        }
                        else
                        {
                            string[] members = parts[2].Split(", ");
                            for (int i = 0; i < members.Length; i++)
                            {
                                if (!bandMembers[bandName].Contains(members[i]))
                                {
                                    bandMembers[bandName].Add(members[i]);
                                }
                            }
                        }
                        break;
                    case "Play":
                        bandName = parts[1];
                        BigInteger time = BigInteger.Parse(parts[2]);
                        if (!bandTime.ContainsKey(bandName))
                        {
                            bandMembers.Add(bandName, new List<string>());
                            bandTime.Add(bandName, time);
                        }
                        else
                        {
                            bandTime[bandName] += time;
                        }
                        break;
                }
            }
            string chosenBand = Console.ReadLine();
            BigInteger totalTime = 0;
            foreach (var item in bandTime)
            {
                totalTime += item.Value;
            }
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in bandTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }
            Console.WriteLine($"{chosenBand}");
            foreach (var name in bandMembers[chosenBand])
            {
                Console.WriteLine($"=> {name}");
            }
        }
    }
}
