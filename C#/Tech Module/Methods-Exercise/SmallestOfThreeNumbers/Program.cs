using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            GetSmallestOfThreeNumbers(num1, num2, num3);
        }
        static void GetSmallestOfThreeNumbers(int a, int b, int c)
        {
            int smallest = 0;
            if (a <= b && a <= c)
            {
                smallest = a;
            }
            if (b <= a && b <= c)
            {
                smallest = b;
            }
            if (c <= a && c <= b)
            {
                smallest = c;
            }
            Console.WriteLine(smallest);
        }
    }
}
