using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string regex = @"(?<!\d)[+]359([ -])2\1\d{3}\1\d{4}\b";
            MatchCollection matches = Regex.Matches(numbers, regex);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
