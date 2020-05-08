using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool trueOrFalse = false;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int recentNum = i;
                while (i > 0)
                { 
                    sum += i % 10;
                    i = i / 10;
                }
                trueOrFalse = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", recentNum, trueOrFalse);
                i = recentNum;
            }
        }
    }
}
