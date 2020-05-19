using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int initialCoins = 0;
            int k = 0;
            string[] rooms = Console.ReadLine().Split('|').ToArray();
            for (int i = 0; i < rooms.Length; i++)
            {
                string[] parts = rooms[i].Split().ToArray();
                if (parts[0] == "potion")
                {
                    int currHealth = initialHealth;
                    int health = int.Parse(parts[1]);
                    if (currHealth + health >= 100)
                    {
                        initialHealth = 100;
                        Console.WriteLine("You healed for {0} hp.", 100 - currHealth);
                    }
                    else
                    {
                        initialHealth = currHealth + health;
                        Console.WriteLine("You healed for {0} hp.", health);
                    }
                    Console.WriteLine("Current health: {0} hp.", initialHealth);
                }
                else if (parts[0] == "chest")
                {
                    int coins = int.Parse(parts[1]);
                    initialCoins += coins;
                    Console.WriteLine("You found {0} coins.", coins);
                }
                else
                {
                    int atack = int.Parse(parts[1]);
                    if (initialHealth - atack > 0)
                    {
                        initialHealth = initialHealth - atack;
                        Console.WriteLine("You slayed {0}.", parts[0]);
                    }
                    else
                    {
                        Console.WriteLine("You died! Killed by {0}.", parts[0]);
                        Console.WriteLine("Best room: {0}", i + 1);
                        break;
                    }
                }
                k++;
            }
            if (k == rooms.Length)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine("Coins: {0}", initialCoins);
                Console.WriteLine("Health: {0}", initialHealth);
            }
        }
    }
}
