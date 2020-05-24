using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = message => Console.WriteLine(message);
            var input = Console.ReadLine().Split()
                .ToArray();
            foreach (var item in input)
            {
                print(item);
            }
        }
    }
}
