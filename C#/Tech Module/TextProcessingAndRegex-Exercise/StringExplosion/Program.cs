using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int strength = 0;
            char[] arr = text.ToCharArray();
            List<char> ar = arr.ToList();
            int k = 0;
            StringBuilder newText = new StringBuilder(text);
            for (int i = 0; i < ar.Count; i++)
            {
                if (i >= newText.Length)
                {
                    break;
                }
                else if (newText[i] == '>')
                {
                    strength += Convert.ToInt32(new string(newText[i + 1], 1));
                }
                else
                {
                    if (strength > 0)
                    {
                        newText.Remove(i, 1);
                        i--;
                        strength--;
                    }
                }
            }
            Console.WriteLine(newText);
        }
    }
}
