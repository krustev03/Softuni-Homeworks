using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vips = new HashSet<string>();

            while(true)
            {
                var input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }

                string guest = input;

                if (Char.IsDigit(guest[0]))
                {
                    vips.Add(guest);
                }
                else
                {
                    regular.Add(guest);
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string guest = input;

                if (Char.IsDigit(guest[0]))
                {
                    vips.Remove(guest);
                }
                else
                {
                    regular.Remove(guest);
                }
            }

            int allCount = regular.Count + vips.Count;

            Console.WriteLine(allCount);

            foreach (var vip in vips)
            {
                Console.WriteLine(vip);
            }
            foreach (var reg in regular)
            {
                Console.WriteLine(reg);
            }
        }
    }
}
