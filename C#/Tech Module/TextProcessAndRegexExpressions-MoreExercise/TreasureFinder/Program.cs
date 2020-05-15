using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> keys = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string encryptMessage = Console.ReadLine();
                if (encryptMessage == "find")
                {
                    break;
                }
                int k = 0;
                char[] characters = encryptMessage.ToCharArray();
                string decryptedMessage = string.Empty;
                for (int i = 0; i < characters.Length; i++)
                {
                    k++;
                    if (i % keys.Count == 0)
                    {
                        k = 0;
                    }
                    decryptedMessage += (char)(characters[i] - keys[k]);
                }
                string resource = decryptedMessage.Substring
                    (decryptedMessage.IndexOf('&') + 1, decryptedMessage.LastIndexOf('&') - decryptedMessage.IndexOf('&') - 1);
                string location = decryptedMessage.Substring
                    (decryptedMessage.IndexOf('<') + 1, decryptedMessage.IndexOf('>') - decryptedMessage.IndexOf('<') - 1);
                Console.WriteLine($"Found {resource} at {location}");
            }
        }
    }
}
