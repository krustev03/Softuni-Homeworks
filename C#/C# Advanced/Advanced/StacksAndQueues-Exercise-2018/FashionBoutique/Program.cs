using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> clothesList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Stack<int> clothes = new Stack<int>(clothesList);
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;
            while (clothes.Any() ==  true)
            {
                if (sum + clothes.Peek() < capacity)
                {
                    sum += clothes.Pop();
                }
                else if (sum + clothes.Peek() == capacity)
                {
                    sum = 0;
                    clothes.Pop();
                    if (clothes.Any() == true)
                    {
                        racks++;
                    }
                }
                else
                {
                    
                    sum = clothes.Pop();
                    racks++;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
