using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            var etaji = int.Parse(Console.ReadLine());
            var rooms = int.Parse(Console.ReadLine());

            for (int i = etaji; i > 0; i--)
            {
                if (i == etaji)
                {
                    for (int r = 0; r < rooms; r++)
                    {
                        Console.Write("L{0}{1} ", i, r);
                    }
                    Console.WriteLine();
                }
                if (i % 2 != 0 && i != etaji)
                {
                    for (int r = 0; r < rooms; r++)
                    {
                        Console.Write("A{0}{1} ", i, r);
                    }
                    Console.WriteLine();
                }
                if (i % 2 == 0 && i != etaji)
                {
                    for (int r = 0; r < rooms; r++)
                    {
                        Console.Write("O{0}{1} ", i, r);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
