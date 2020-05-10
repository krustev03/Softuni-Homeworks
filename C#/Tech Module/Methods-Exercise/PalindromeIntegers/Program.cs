using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                char[] digits = input.ToCharArray();
                if (digits.Length % 2 == 0)
                {
                    char[] first = new char[digits.Length / 2];
                    char[] second = new char[digits.Length / 2];
                    for (int i = 0; i < first.Length; i++)
                    {
                        first[i] = digits[i];
                    }
                    for (int i = 0; i < second.Length; i++)
                    {
                        second[i] = digits[second.Length + i];
                    }
                    Array.Reverse(second);
                    int k = 0;
                    for (int i = 0; i < first.Length; i++)
                    {
                        if (first[i] != second[i])
                        {
                            k = 1;
                        }
                    }
                    if (k == 1)
                    {
                        Console.WriteLine("false");
                    }
                    else
                    {
                        Console.WriteLine("true");
                    }
                }
                if (digits.Length % 2 != 0)
                {
                    char[] first = new char[digits.Length / 2];
                    char[] second = new char[digits.Length / 2];
                    for (int i = 0; i < first.Length; i++)
                    {
                        first[i] = digits[i];
                    }
                    for (int i = 1; i <= second.Length; i++)
                    {
                        second[i - 1] = digits[second.Length + i];
                    }
                    Array.Reverse(second);
                    int k = 0;
                    for (int i = 0; i < first.Length; i++)
                    {
                        if (first[i] != second[i])
                        {
                            k = 1;
                        }
                    }
                    if (k == 1)
                    {
                        Console.WriteLine("false");
                    }
                    else
                    {
                        Console.WriteLine("true");
                    }
                }
            }
        }
    }
}
