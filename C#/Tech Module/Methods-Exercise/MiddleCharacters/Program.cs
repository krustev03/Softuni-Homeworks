using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string middle = GetMiddleChars(str);
            Console.WriteLine(middle);
        }
        static string GetMiddleChars(string str)
        {
            string middleChars = "";
            char[] letters = str.ToCharArray();
            if (str.Length % 2 == 0)
            {
                middleChars = Convert.ToString(letters[letters.Length / 2 - 1]) + letters[letters.Length / 2];
            }
            else
            {
                middleChars = Convert.ToString(letters[letters.Length / 2]);
            }
            return middleChars;
        }
    }
}
