using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();

            string input = Console.ReadLine();

            char[] chars = input.ToCharArray();

            foreach (var character in chars)
            {
                if (!characters.ContainsKey(character))
                {
                    characters.Add(character, 0);
                }

                characters[character]++;
            }

            foreach (var item in characters.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
