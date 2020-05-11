using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                switch (tokens[2])
                {
                    case "not":
                        if (names.Contains(tokens[0]))
                        {
                            names.Remove(tokens[0]);
                        }
                        else
                        {
                            Console.WriteLine($"{tokens[0]} is not in the list!");
                        }
                        break;
                    case "going!":
                        if (names.Contains(tokens[0]))
                        {
                            Console.WriteLine($"{tokens[0]} is already in the list!");
                        }
                        else
                        {
                            names.Add(tokens[0]);
                        }
                        break;
                }
                n--;
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i] + " ");
            }
        }
    }
}
