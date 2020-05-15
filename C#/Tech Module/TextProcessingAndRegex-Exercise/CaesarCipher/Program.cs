using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                var newLetter = (int)text[i] + 3;
                newText.Append((char)newLetter);
            }
            Console.WriteLine(newText);
        }
    }
}
