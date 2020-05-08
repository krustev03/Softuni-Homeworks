using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 97; i < n + 97; i++)
            {
                for (int k = 97; k < n + 97; k++)
                {
                    for (int l = 97; l < n + 97; l++)
                    {
                        Console.WriteLine($"{(char)i}{(char)k}{(char)l}");
                    }
                }
            }
        }
    }
}
