using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            GetCharsBetweenTwoChars(a, b);
        }
        static void GetCharsBetweenTwoChars(char start, char end)
        {
            if(start > end)
            {
                char exchange = start;
                start = end;
                end = exchange;
            }
            for (int i = (int)start + 1; i < (int)end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
