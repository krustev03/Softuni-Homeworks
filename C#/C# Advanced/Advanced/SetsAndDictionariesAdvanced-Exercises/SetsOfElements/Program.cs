using System;
using System.Collections.Generic;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            var input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            for (int i = 0; i < n + m; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    first.Add(num);
                }
                else
                {
                    second.Add(num);
                }
            }

            foreach (var num in first)
            {
                if (second.Contains(num))
                {
                    Console.Write(num + " ");
                }
            }
        }
    }
}
