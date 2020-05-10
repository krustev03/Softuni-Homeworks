using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (operation == "add")
            {
                Add(num1, num2);
            }
            if (operation == "multiply")
            {
                Multiply(num1, num2);
            }
            if (operation == "subtract")
            {
                Subtract(num1, num2);
            }
            if (operation == "divide")
            {
                Divide(num1, num2);
            }
        }
        static void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
        }
        static void Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
        static void Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
