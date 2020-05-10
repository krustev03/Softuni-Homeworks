using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            switch(type)
            {
                case "int":
                    int num = int.Parse(Console.ReadLine());
                    Print(num);
                    break;
                case "real":
                    double real = double.Parse(Console.ReadLine());
                    Print(real);
                    break;
                case "string":
                    string str = Console.ReadLine();
                    Print(str);
                    break; ;
                default: break;
            }
        }
        static void Print(int num)
        {
            Console.WriteLine(num * 2);
        }
        static void Print(double num)
        {
            double result = num * 1.50;
            Console.WriteLine("{0:f2}", result);
        }
        static void Print(string str)
        {
            Console.WriteLine("$" + str + "$");
        }
    }
}
