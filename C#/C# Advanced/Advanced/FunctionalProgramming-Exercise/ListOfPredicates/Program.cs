using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int[] removers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = new List<int>();
            
            for (int i = 1; i <= end; i++)
            {
                bool k = true;

                foreach (var divider in removers)
                {
                    bool isDividible = Remover(i, divider);
                    if (isDividible == false)
                    {
                        k = false;
                    }
                }

                if (k)
                {
                    result.Add(i);
                }
            }

            string print = String.Join(" ", result);
            Console.WriteLine(print);
        }

        private static bool Remover(int num, int n)
        {
            bool result;
            if (num % n == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
