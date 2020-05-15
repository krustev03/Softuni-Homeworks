using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string first = strings[0];
            string second = strings[1];
            int totalSum = 0;
            if (first.Length > second.Length)
            {
                for (int i = 0; i < second.Length; i++)
                {
                    totalSum += (int)first[i] * (int)second[i];
                }
                for (int i = second.Length; i < first.Length; i++)
                {
                    totalSum += first[i];
                }
            }
            else if (first.Length < second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    totalSum += (int)first[i] * (int)second[i];
                }
                for (int i = first.Length; i < second.Length; i++)
                {
                    totalSum += second[i];
                }
            }
            else
            {
                for (int i = 0; i < second.Length; i++)
                {
                    totalSum += (int)first[i] * (int)second[i];
                }
            }
            Console.WriteLine(totalSum);
        }
    }
}
