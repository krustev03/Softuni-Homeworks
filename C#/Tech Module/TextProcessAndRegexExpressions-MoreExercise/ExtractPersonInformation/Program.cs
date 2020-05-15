using System;
using System.Text.RegularExpressions;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int indexName = text.IndexOf("@") + 1;
                string name = text.Substring(indexName, text.IndexOf("|") - indexName);
                int indexAge = text.IndexOf("#") + 1;
                string age = text.Substring(indexAge, text.IndexOf("*") - indexAge);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
