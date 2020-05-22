using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> chemicals = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                foreach (var chemical in input)
                {
                    chemicals.Add(chemical);
                }
            }

            foreach (var chemical in chemicals.OrderBy(x => x))
            {
                Console.Write(chemical + " ");
            }
        }
    }
}
