using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersAsString = Console.ReadLine().Split(' ');
            List<double> numbers = new List<double>();
            foreach (var numberAsString in numbersAsString)
            {
                numbers.Add(double.Parse(numberAsString));
            }
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            foreach(var number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    //count[number].Add(number, 1);
                    counts[number] = 1;
                }
            }
            foreach(var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
