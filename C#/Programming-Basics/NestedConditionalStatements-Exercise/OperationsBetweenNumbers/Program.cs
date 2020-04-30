using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            string evenOrOdd = "";
            double result = 0.0;
            if (operation == "+" || operation == "-" || operation == "*")
            {
                if (operation == "+")
                {
                    result = n1 + n2;
                }
                else if (operation == "-")
                {
                    result = n1 - n2;
                }
                else if (operation == "*")
                {
                    result = n1 * n2;
                }
                if (result % 2 == 0)
                {
                    evenOrOdd = "even";
                }
                else
                {
                    evenOrOdd = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, result, evenOrOdd);
            }
            if (operation == "/" || operation == "%")
            {
                if (operation == "/")
                {
                    double n11 = n1;
                    result = n11 / n2;
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} = {3:f2}", n1, operation, n2, result);
                    }
                }
                else if (operation == "%")
                {
                    if (n2 == 0)
                    {
                        Console.WriteLine("Cannot divide {0} by zero", n1);
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine("{0} {1} {2} = {3}", n1, operation, n2, result);
                    }
                }
            }
        }
    }
}
