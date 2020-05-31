using System;
using System.Linq;
using System.Collections.Generic;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chemicalLiquidsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] physicalItemsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> chemicalLiquids = new Queue<int>(chemicalLiquidsInput);
            Stack<int> physicalItems = new Stack<int>(physicalItemsInput);

            Dictionary<string, int> itemsCount = new Dictionary<string, int>();
            itemsCount.Add("Glass", 0);
            itemsCount.Add("Aluminium", 0);
            itemsCount.Add("Lithium", 0);
            itemsCount.Add("Carbon fiber", 0);

            while (chemicalLiquids.Any() && physicalItems.Any())
            {
                if (chemicalLiquids.Peek() + physicalItems.Peek() == 25)
                {
                    itemsCount["Glass"]++;
                    physicalItems.Pop();
                    chemicalLiquids.Dequeue();
                }
                else if (chemicalLiquids.Peek() + physicalItems.Peek() == 50)
                {
                    itemsCount["Aluminium"]++;
                    physicalItems.Pop();
                    chemicalLiquids.Dequeue();
                }
                else if (chemicalLiquids.Peek() + physicalItems.Peek() == 75)
                {
                    itemsCount["Lithium"]++;
                    physicalItems.Pop();
                    chemicalLiquids.Dequeue();
                }
                else if (chemicalLiquids.Peek() + physicalItems.Peek() == 100)
                {
                    itemsCount["Carbon fiber"]++;
                    physicalItems.Pop();
                    chemicalLiquids.Dequeue();
                }
                else
                {
                    chemicalLiquids.Dequeue();
                    var oldPIValue = physicalItems.Pop();
                    physicalItems.Push(oldPIValue + 3);
                }
            }

            if (itemsCount["Glass"] > 0 && itemsCount["Aluminium"] > 0
                && itemsCount["Lithium"] > 0 && itemsCount["Carbon fiber"] > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (chemicalLiquids.Any())
            {
                Console.Write("Liquids left: ");
                Console.WriteLine(String.Join(", ", chemicalLiquids));
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (physicalItems.Any())
            {
                Console.Write("Physical items left: ");
                Console.WriteLine(String.Join(", ", physicalItems));
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var item in itemsCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
