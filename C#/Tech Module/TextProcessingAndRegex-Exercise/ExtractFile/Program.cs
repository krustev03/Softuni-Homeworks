using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();
            string extension = file.Substring(file.LastIndexOf(".") + 1);
            string name = file.Substring(file.LastIndexOf('\\') + 1, file.LastIndexOf('.') - file.LastIndexOf('\\') - 1);
            Console.WriteLine();
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
