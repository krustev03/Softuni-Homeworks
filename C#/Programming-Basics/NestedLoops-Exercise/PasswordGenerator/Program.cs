using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (char k = 'a'; k < l + 'a'; k++)
                    {
                        for (char o = 'a'; o < l + 'a'; o++)
                        {
                            for (int m = 1; m <= n; m++)
                            {
                                if ((i < m) && (j < m))
                                Console.Write($"{i}{j}{k}{o}{m}" + " ");
                            }
                        }
                    }
                }
            }
        }
    }
}
