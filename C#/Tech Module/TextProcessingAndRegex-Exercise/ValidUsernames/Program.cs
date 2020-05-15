using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine().Split(", ").ToList();
            foreach (var name in usernames)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    int k = 0;
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!(Char.IsDigit(name[i]) || Char.IsLetter(name[i]) || name[i] == '-' || name[i] == '_'))
                        {
                            k = 1;
                        }
                    }
                    if (k == 0)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
        }
    }
}
