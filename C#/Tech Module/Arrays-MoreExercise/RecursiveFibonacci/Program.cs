using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] memo = new long[n + 1];
            Console.WriteLine(GetFibonacci(n, memo));
        }
        public static long GetFibonacci(int n, long[] memo)
        {
            
            if (n <= 2)
            {
                return 1;
            }
            if (memo[n] != 0)
            {
                return memo[n];
            }
            memo[n] = GetFibonacci(n - 1, memo) + GetFibonacci(n - 2, memo);
            return memo[n];
            
        }
    }
}
