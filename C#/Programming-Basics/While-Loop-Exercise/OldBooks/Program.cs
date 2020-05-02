using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favourite = Console.ReadLine();
            int capacity = int.Parse(Console.ReadLine());
            int searches = 1;
            int check = 0;
            while (searches <= capacity || check == 1)
            {
                string name = Console.ReadLine();
                if (name == favourite)
                {
                    Console.WriteLine("You checked {0} books and found it.", searches - 1);
                    break; 
                }
                if (name != favourite && searches == capacity)
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine("You checked {0} books.", searches);
                    break;
                }
                searches++;
            }
        }
    }
}
