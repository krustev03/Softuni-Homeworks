using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            var command = Console.ReadLine();
            string[] words = command.Split(" | ");
            for (int i = 0; i < words.Length; i++)
            {
                string[] parts = words[i].Split(": ");
                string word = parts[0];
                string definition = parts[1];
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, new List<string>());
                    if (!dic[word].Contains(definition))
                    {
                        dic[word].Add(definition);
                    }
                }
                else
                {
                    if (!dic[word].Contains(definition))
                    {
                        dic[word].Add(definition);
                    }
                }
            }
            
            string[] wordsToPrint = Console.ReadLine().Split(" | ");
            List<string> correctWords = new List<string>();
            foreach (var word in wordsToPrint)
            {
                if (dic.ContainsKey(word))
                {
                    correctWords.Add(word);
                }
            }
            foreach (var word in correctWords.OrderBy(x => x))
            {
                Console.WriteLine($"{word}");
                foreach (var definition in dic[word].OrderByDescending(x => x.Length))
                {
                    Console.WriteLine($" -{definition}");
                }
            }
            string commandToPrint = Console.ReadLine();
            if (commandToPrint == "List")
            {
                foreach (var word in dic.OrderBy(x => x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
