using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int max = GetMax(num1, num2);
                Console.WriteLine(max);
            }
            if (input == "char")
            {
                char one = char.Parse(Console.ReadLine());
                char two = char.Parse(Console.ReadLine());
                GetMax(one, two);
            }
            if (input == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                GetMax(str1, str2);
            }
        }
        static int GetMax(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;
        }
        static void GetMax(char one, char two)
        {
            if ((int)one > (int)two)
            {
                Console.WriteLine(one);
            }
            if ((int)one <= (int)two)
            {
                Console.WriteLine(two);
            }
        }
        static void GetMax(string str1, string str2)
        {
            if (str1.CompareTo(str2) >= 0)
            {
                Console.WriteLine(str1);
            }
            else
            {
                Console.WriteLine(str2);
            }
        }
        static int MakeStringToCharArrayAndSum(string s)
        {
            char[] letters = s.ToCharArray();
            int sum = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                sum += (int)letters[i];
            }
            return sum;
        }
    }
}

