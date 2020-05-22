using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                var clothes = input[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var clothe in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothe))
                    {
                        wardrobe[color].Add(clothe, 0);
                    }

                    wardrobe[color][clothe]++;
                }
            }

            var match = Console.ReadLine().Split();
            string chosenColor = match[0];
            string chosenClothe = match[1];

            foreach (var item in wardrobe)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var clothe in wardrobe[item.Key])
                {
                    if (chosenColor == item.Key && chosenClothe == clothe.Key)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
