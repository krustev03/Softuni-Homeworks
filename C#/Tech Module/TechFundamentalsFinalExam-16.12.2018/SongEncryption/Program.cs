using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                var parts = command.Split(":");
                string actor = parts[0];
                string song = parts[1];
                string regexForArtist = @"^[A-Z][a-z\' ]{1,}$";
                string regexForSong = @"^[A-Z\ ]{1,}$";
                if (Regex.IsMatch(actor.ToString(), regexForArtist) && Regex.IsMatch(song.ToString(), regexForSong))
                {
                    int key = actor.Length;
                    StringBuilder decrypted = new StringBuilder();
                    decrypted.Append(command);
                    decrypted.Replace(":", "@");
                    for (int i = 0; i < command.Length; i++)
                    {
                        if (decrypted[i] != ' ' && decrypted[i] != '\'')
                        {
                            if (char.IsUpper(decrypted[i]))
                            {
                                for (int k = 1; k <= key; k++)
                                {
                                    decrypted[i]++;
                                    if (decrypted[i] > 90)
                                    {
                                        decrypted[i] = 'A';
                                    }
                                }
                            }
                            if (char.IsLower(decrypted[i]))
                            {
                                for (int k = 1; k <= key; k++)
                                {
                                    decrypted[i]++;
                                    if (decrypted[i] > 122)
                                    {
                                        decrypted[i] = 'a';
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine("Successful encryption: " + decrypted);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
