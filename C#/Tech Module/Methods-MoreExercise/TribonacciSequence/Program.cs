using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTribonacci(n);
        }
        static void PrintTribonacci(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("0");
            }
            if (n == 1)
            {
                Console.WriteLine("1");
            }
            if (n == 2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                int[] dp = new int[n];
                dp[0] = dp[1] = 1;
                dp[2] = 2;

                for (int i = 3; i < n; i++)
                    dp[i] = dp[i - 1] +
                            dp[i - 2] +
                            dp[i - 3];

                for (int i = 0; i < n; i++)
                    Console.Write(dp[i] + " ");
            }
        }
    }
}
