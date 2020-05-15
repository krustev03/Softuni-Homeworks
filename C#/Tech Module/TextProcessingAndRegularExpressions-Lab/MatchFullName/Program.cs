using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var regex = @"\b[A-Z][a-z]+[\s{1}][A-Z][a-z]+\b";
            var matched = Regex.Matches(text, regex);
            foreach (var name in matched)
            {
                Console.Write(name + " ");
            }
        }
    }
}
