using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < items.Length / 2; i++)
            {
                var oldElement = items[i];
                items[i] = items[items.Length - i - 1];
                items[items.Length - i - 1] = oldElement; 
            }
            Console.WriteLine(String.Join(" ", items));
        }
    }
}
