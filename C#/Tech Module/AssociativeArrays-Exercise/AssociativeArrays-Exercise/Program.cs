using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                for (int k = 0; k < letters.Length; k++)
                {
                    if (letters[k] != ' ')
                    {
                        if (!counts.ContainsKey(letters[k]))
                        {
                            counts.Add(letters[k], 0);
                        }
                        counts[letters[k]]++;
                    }
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
