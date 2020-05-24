using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Predicate<string> valid = name => name.Length <= length;
            foreach (var name in names)
            {
                if (valid(name) == true)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
