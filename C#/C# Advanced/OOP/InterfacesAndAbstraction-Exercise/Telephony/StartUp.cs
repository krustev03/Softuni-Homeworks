using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var sites = Console.ReadLine().Split();

            Smartphone phone = new Smartphone();

            foreach (var number in numbers)
            {
                Console.WriteLine(phone.Call(number));
            }

            foreach (var site in sites)
            {
                Console.WriteLine(phone.Browse(site));
            }
        }
    }
}
