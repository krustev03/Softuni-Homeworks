using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool first = IfDividibleBy8(i);
                bool second = IfAtLeastOneOddDigit(i);
                if (first && second)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool IfDividibleBy8(int num)
        {
            bool right = false;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            if (sum % 8 == 0)
            {
                right = true;
            }
            return right;
        }
        static bool IfAtLeastOneOddDigit(int num)
        {
            bool right = false;
            while (num > 0)
            {
                if ((num % 10) % 2 != 0)
                {
                    right = true;
                }
                num = num / 10;
            }
            return right;
        }
    }
}
