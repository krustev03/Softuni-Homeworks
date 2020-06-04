using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Queue<IBuyer> all = new Queue<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string info = Console.ReadLine();
                var tokens = info.Split();

                if (tokens.Length == 4)
                {
                    all.Enqueue(new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }

                else if (tokens.Length == 3)
                {
                    all.Enqueue(new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]));
                }
            }

            int purchasedFood = 0;

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "End")
                {
                    break;
                }

                foreach (var human in all)
                {
                    if (human.Name == name)
                    {
                        human.BuyFood();

                        if (human is Citizen)
                        {
                            purchasedFood += 10;
                        }
                        
                        else if (human is Rebel)
                        {
                            purchasedFood += 5;
                        }
                    }
                }
            }

            Console.WriteLine(purchasedFood);
        }
    }
}
