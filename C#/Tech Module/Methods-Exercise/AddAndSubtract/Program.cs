using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            int result = Subtract(sum, num3);
            Console.WriteLine(result);
        }
        static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
