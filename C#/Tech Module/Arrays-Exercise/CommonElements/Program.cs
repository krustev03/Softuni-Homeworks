using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var items1 = Console.ReadLine().Split().ToArray();
            var items2 = Console.ReadLine().Split().ToArray();
            for (int i = 0; i < items2.Length; i++)
            {
                for (int k = 0; k < items1.Length; k++)
                {
                    if (items2[i] == items1[k])
                    {
                        Console.Write(items2[i] + " ");
                    }
                }
            }
        }
    }
}
