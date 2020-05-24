using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];
            string station = Console.ReadLine();
            Predicate<string> oddOrEven = s => s.Equals("odd");
            bool result = oddOrEven(station);
            Func<bool, int, int, string> printer = Print;
            string resultArr = printer(result, start, end);
            Console.WriteLine(resultArr);
        }

        private static string Print(bool result, int start, int end)
        {
            string resultArr = string.Empty;
            switch (result)
            {
                case false:
                    var evens = new List<int>();
                    for (int i = start; i < end + 1; i++)
                    {
                        if (i % 2 == 0)
                        evens.Add(i);
                    }
                    resultArr = String.Join(" ", evens);
                    break;
                case true:
                    var odds = new List<int>();
                    for (int i = start; i < end + 1; i++)
                    {
                        if (i % 2 != 0)
                            odds.Add(i);
                    }
                    resultArr = String.Join(" ", odds);
                    break;
            }
            return resultArr;
        }
    }
}
