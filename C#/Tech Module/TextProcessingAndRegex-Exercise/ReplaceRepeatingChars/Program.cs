using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text.Distinct().Select(c => c.ToString()).ToList()
        .ForEach(c =>
        {
            while (text.Contains(c + c))
            text = text.Replace(c + c, c);
        }
        );
            Console.WriteLine(text);
        }
    }
}
