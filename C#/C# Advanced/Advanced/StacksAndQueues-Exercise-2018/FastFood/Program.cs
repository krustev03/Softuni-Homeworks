using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            List<int> ordersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> orders = new Queue<int>(ordersList);
            Queue<int> copyOrders = new Queue<int>(ordersList);
            int max = copyOrders.Dequeue();
            while (copyOrders.Any() == true)
            {
                if (max < copyOrders.Peek())
                {
                    max = copyOrders.Dequeue();
                }
                else
                {
                    copyOrders.Dequeue();
                }
            }
            
            while (orders.Any() == true)
            {
                if (quantity - orders.Peek() < 0)
                {
                    quantity = -1;
                    break;
                }
                quantity -= orders.Dequeue();
            }

            Console.WriteLine(max);

            if (quantity >= 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                while (orders.Any() == true)
                {
                    Console.Write(orders.Dequeue() + " ");
                }
            }
        }
    }
}
