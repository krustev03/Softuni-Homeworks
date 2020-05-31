using System;
using System.Linq;
using System.Collections.Generic;

namespace TrojanInvasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfWaves = int.Parse(Console.ReadLine());

            int[] platesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> plates = new Queue<int>(platesInput);

            Stack<int> trojans = new Stack<int>();

            Queue<int> leftTrojans = new Queue<int>();

            bool win = false;

            for (int i = 1; i <= numOfWaves; i++)
            {
                int[] trojansInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (plates.Any())
                {
                    trojans = new Stack<int>(trojansInput);

                    if (i % 3 == 0)
                    {
                        int newPlate = int.Parse(Console.ReadLine());
                        plates.Enqueue(newPlate);
                    }

                    while (trojans.Any())
                    {
                        var diff = trojans.Peek() - plates.Peek();

                        trojans.Pop();
                        plates.Dequeue();

                        if (diff > 0)
                        {
                            trojans.Push(diff);
                        }

                        else if (diff < 0)
                        {
                            var oldPlates = plates;
                            plates = new Queue<int>();
                            plates.Enqueue(Math.Abs(diff));
                            foreach (var item in oldPlates)
                            {
                                plates.Enqueue(item);
                            }
                        }

                        if (plates.Any() == false)
                        {
                            win = true;
                            if (trojans.Any())
                            {
                                leftTrojans = new Queue<int>(trojans);
                                trojans = new Stack<int>();
                            }
                           
                        }
                    }
                }
            }

            if (win)
            {
                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.Write("Warriors left: ");
                Console.WriteLine(String.Join(", ", leftTrojans)); 
            }

            else
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.Write("Plates left: ");
                Console.WriteLine(String.Join(", ", plates)); 
            }
        }
    }
}
