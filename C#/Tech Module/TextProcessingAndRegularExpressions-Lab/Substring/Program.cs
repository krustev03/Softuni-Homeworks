using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            var part = Console.ReadLine();
            var input = Console.ReadLine();
            
            var index = input.IndexOf(part);
            while (index != -1)
            {
                input = input.Remove(index, part.Length);
                index = input.IndexOf(part);
            }
            Console.WriteLine(input);
        }
    }
}
