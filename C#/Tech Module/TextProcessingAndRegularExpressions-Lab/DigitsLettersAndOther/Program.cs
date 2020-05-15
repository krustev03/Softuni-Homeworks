using System;
using System.Text.RegularExpressions;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (!(Char.IsLetter(text[i]) || Char.IsDigit(text[i])))
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
