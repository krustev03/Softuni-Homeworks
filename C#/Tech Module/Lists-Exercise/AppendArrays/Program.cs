using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> all = Console.ReadLine().Split('|').Reverse().ToList();
            List<int> numbers = new List<int>();
            foreach (var str in all)
            {
                numbers.AddRange(str.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                     );
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
