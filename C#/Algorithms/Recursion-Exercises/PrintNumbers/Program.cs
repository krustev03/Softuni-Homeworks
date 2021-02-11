using System;

namespace PrintNumbers
{
    class Program
    {
        static int counter = 1;

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            PrintNumbers(n, k);
        }

        static void PrintNumbers(int n, int k)
        {
            for (int i = counter; i <= n; i++)
            {
                if (counter == n && i == n)
                {
                    Console.Write($"({counter} {i})");
                }
                else
                {
                    Console.Write($"({counter} {i}), ");
                }
            }

            counter++;

            if (counter <= n)
            {
                PrintNumbers(n, k);
            }

            return;
        }
    }
}
