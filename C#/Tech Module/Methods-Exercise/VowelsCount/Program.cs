using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            int result = GetVowelsInAString(str);
            Console.WriteLine(result);
        }
        static int GetVowelsInAString(string str)
        {
            int vowels = 0;
            char[] letters = str.ToCharArray();
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == 'a' || letters[i] == 'o' || letters[i] == 'u' ||
                    letters[i] == 'i'  || letters[i] == 'e')
                {
                    vowels++;
                }
            }
            return vowels;
        }
    }
}
