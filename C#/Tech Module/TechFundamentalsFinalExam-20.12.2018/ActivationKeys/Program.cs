using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ActivationKeys
{
    class Program
    {
        public static void Main(String[] args)
        {
            var validKeys = Console.ReadLine().Split('&').Where(IsValid).Select(FixKey).ToList();

            Console.WriteLine(string.Join(", ", validKeys));
        }

        private static bool IsValid(string possibleKey)
        {
            var pattern = @"^[a-zA-Z0-9]+$";
            var match = Regex.Match(possibleKey, pattern);

            if (match.Success)
            {
                return possibleKey.Length == 25 || possibleKey.Length == 16;
            }

            return false;
        }

        private static string FixKey(string key)
        {
            var fixedKey = new StringBuilder();
            // put dash after every forth or fifth character
            var divisorNumber = key.Length == 25 ? 5 : 4;

            for (int i = 0; i < key.Length; i++)
            {
                var character = key[i];

                if (char.IsLetter(character))
                {
                    fixedKey.Append(char.ToUpper(character));
                }
                else
                {
                    var digit = 9 - int.Parse(character.ToString());
                    fixedKey.Append(digit);
                }

                if ((i + 1) % divisorNumber == 0)
                {
                    fixedKey.Append("-");
                }
            }

            fixedKey = fixedKey.Remove(fixedKey.Length - 1, 1);

            return fixedKey.ToString();
        }
    }
}
