using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morseAlphabet = new Dictionary<string, string>()
            {
                                       {".-", "A"},
                                       {"-...", "B"},
                                       {"-.-.", "C"},
                                       {"-..", "D"},
                                       {".", "E"},
                                       {"..-.", "F"},
                                       {"--.", "G"},
                                       {"....", "H"},
                                       {"..", "I"},
                                       {".---", "J"},
                                       {"-.-", "K"},
                                       {".-..", "L"},
                                       {"--", "M"},
                                       {"-.", "N"},
                                       {"---", "O"},
                                       {".--.", "P"},
                                       {"--.-", "Q"},
                                       {".-.", "R"},
                                       {"...", "S"},
                                       {"-", "T"},
                                       {"..-", "U"},
                                       {"...-", "V"},
                                       {".--", "W"},
                                       {"-..-", "X"},
                                       {"-.--", "Y"},
                                       {"--..", "Z"},

            };
            List<string> codes = Console.ReadLine().Split(" ").ToList();
            string message = string.Empty;
            foreach (var code in codes)
            {
                if (morseAlphabet.ContainsKey(code))
                {
                    message += morseAlphabet[code];
                }
                if (code == "|")
                {
                    message += " ";
                }
            }
            Console.WriteLine(message);
        }
    }
}
