using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            string result = PrintStringNTimes(str, times);
            Console.WriteLine(result);
        }
        static string PrintStringNTimes(string str, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
