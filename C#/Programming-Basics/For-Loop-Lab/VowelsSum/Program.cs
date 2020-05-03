using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            int sum = 0;
            int a = 1;
            int e = 2;
            int i = 3;
            int o = 4;
            int u = 5;

            Console.WriteLine();

            for (int r = 0; r <= s.Length - 1; r++)
            {
                if (s[r] == 'a')
                {
                    sum += a;
                }
                if (s[r] == 'e')
                {
                    sum += e;
                }
                if (s[r] == 'i')
                {
                    sum += i;
                }
                if (s[r] == 'o')
                {
                    sum += o;
                }
                if (s[r] == 'u')
                {
                    sum += u;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
