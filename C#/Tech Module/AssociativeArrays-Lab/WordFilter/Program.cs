using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(a => a.Length % 2 == 0).ToArray();
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
