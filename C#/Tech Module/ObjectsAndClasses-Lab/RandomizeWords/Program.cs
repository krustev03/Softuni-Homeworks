using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().Split().ToList();
            Random rnd = new Random();
            for (int i = 0; i < words.Count; i = 0)
            {
                var word = rnd.Next(0, words.Count);
                Console.WriteLine(words[word]);
                words.Remove(words[word]);
            }
            
        }
    }
}
