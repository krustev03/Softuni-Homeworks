using System;
using System.Linq;
using System.Collections.Generic;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, bool> checker = n => Char.IsUpper(n[0]);
            var words = input.Split(new string[] { " " },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
