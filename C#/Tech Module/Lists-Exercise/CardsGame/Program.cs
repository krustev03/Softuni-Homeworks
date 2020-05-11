using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(firstDeck[0]);
                    firstDeck.Add(secondDeck[0]);
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (firstDeck[0] < secondDeck[0])
                {
                    secondDeck.Add(secondDeck[0]);
                    secondDeck.Add(firstDeck[0]);
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
                else if (firstDeck[0] == secondDeck[0])
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }
            if (firstDeck.Count == 0)
            {
                int sum = 0;
                for (int i = 0; i < secondDeck.Count; i++)
                {
                    sum += secondDeck[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            if (secondDeck.Count == 0)
            {
                int sum = 0;
                for (int i = 0; i < firstDeck.Count; i++)
                {
                    sum += firstDeck[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
