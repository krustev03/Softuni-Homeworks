using System;
using System.Text.RegularExpressions;

namespace AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            if (first > second)
            {
                char changer = first;
                first = second;
                second = changer;
            }
            string text = Console.ReadLine();
            var arr = text.ToCharArray();
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((int)first < (int)arr[i] && (int)arr[i] < (int)second)
                {
                    sum += (int)arr[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
