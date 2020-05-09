using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_SortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            int[] sums = new int[n];
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
                int sum = 0;
                foreach (char letter in str[i])
                {
                    if (letter == 'a' || letter == 'e' || letter == 'o' ||
                                         letter == 'u' || letter == 'i' ||
                        letter == 'A' || letter == 'E' || letter == 'O' ||
                                         letter == 'U' || letter == 'I')
                    {
                        sum += (int)letter * str[i].Length;
                    }
                    else
                    {
                        sum += (int)letter / str[i].Length;
                    }
                }
                sums[i] = sum;
             }
            Array.Sort(sums);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sums[i]);
            }
        }
    }
}
