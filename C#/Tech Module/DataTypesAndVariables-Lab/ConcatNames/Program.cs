using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var delimiter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimiter}{secondName}");
        }
    }
}
