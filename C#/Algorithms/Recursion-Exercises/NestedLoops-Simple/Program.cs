using System;

namespace NestedLoops_Simple
{
    class Program
    {
        static int counter = 1;

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            PrintNestedLoops(n - 1);
        }

        static void PrintNestedLoops(int n)
        {
            if (n < 0)
            {
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            PrintNestedLoops(n - 1);
        }
    }
}
