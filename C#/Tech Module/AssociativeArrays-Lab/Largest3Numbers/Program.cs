using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] sorted = numbers.OrderByDescending(x => x).ToArray();
            int k = 3;
            if (sorted.Length < 3)
            {
                k = sorted.Length;
            }
            for (int i = 0; i < k; i++)
            {
                Console.Write(sorted[i] + " ");
            }
        }
    }
}
