using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Last note")
                {
                    break;
                }
                // Name
                string name = input.Substring(0, input.IndexOf("="));
                // GeoHash Code Length
                string geoLength = input.Substring(input.IndexOf("=") + 1, input.IndexOf("<<") - input.IndexOf("=") - 1);
                // GeoHash Code
                string geohashCode = input.Substring(input.IndexOf("<<") + 2);
                // Check input validation
                string rightOrderAndInput = @"^[\!@#$?a-zA-Z0-9]{1,}[=][0-9]{1,}[<]{2}[a-zA-Z0-9]{1,}$";

                if (Regex.IsMatch(input, rightOrderAndInput))
                {
                    int num = int.Parse(geoLength);
                    if (num == geohashCode.Length)
                    {
                        string output = string.Empty;
                        for (int i = 0; i < name.Length; i++)
                        {
                            if (Char.IsLetter(name[i]) || Char.IsDigit(name[i]))
                            {
                                output += name[i];
                            }
                        }
                        Console.WriteLine($"Coordinates found! {output} -> {geohashCode}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
