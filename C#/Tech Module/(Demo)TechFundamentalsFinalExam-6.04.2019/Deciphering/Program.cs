using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypted = Console.ReadLine();
            string[] messages = Console.ReadLine().Split(" ");
            StringBuilder decrypted = new StringBuilder();
            for (int i = 0; i < encrypted.Length; i++)
            {
                decrypted.Append((char)(encrypted[i] - 3));
            }
            string regex = @"^[A-Ca-z\{}|# ]{1,}$";
            if (!Regex.IsMatch(decrypted.ToString(), regex))
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {
                decrypted.Replace(messages[0], messages[1]);
                Console.WriteLine(decrypted);
            }
            
            
        }
    }
}
