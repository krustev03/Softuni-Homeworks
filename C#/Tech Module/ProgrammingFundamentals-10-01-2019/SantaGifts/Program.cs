using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currPosition = 0;
            for (int i = 0; i < numOfCommands; i++)
            {
                var command = Console.ReadLine();
                string[] parts = command.Split();
                switch (parts[0])
                {
                    case "Forward":
                        int movePositionsFor = int.Parse(parts[1]);
                        if (currPosition + movePositionsFor < houses.Count)
                        {
                            currPosition += movePositionsFor;
                            houses.RemoveAt(currPosition);
                            
                        }
                        break;
                    case "Back":
                        int movePositionsBack = int.Parse(parts[1]);
                        if (currPosition - movePositionsBack >= 0)
                        {
                            currPosition -= movePositionsBack;
                            houses.RemoveAt(currPosition);
                        }
                        break;
                    case "Gift":
                        int index = int.Parse(parts[1]);
                        int element = int.Parse(parts[2]);
                        if (index >= 0 && index < houses.Count)
                        {
                            houses.Insert(index, element);
                            currPosition = index;
                        }
                        break;
                    case "Swap":
                        int elementOne = int.Parse(parts[1]);
                        int elementTwo = int.Parse(parts[2]);
                        int indexOne = 0;
                        int indexTwo = 0;
                        int p = 0;
                        int m = 0;
                        if (houses.Contains(elementOne) == true && houses.Contains(elementTwo) == true)
                        {
                           
                            for (int k = 0; k < houses.Count; k++)
                            {
                                if (houses[k] == elementTwo && p == 0)
                                {
                                    indexTwo = k;
                                    p = 1;
                                }
                                if (houses[k] == elementOne && m == 0)
                                {
                                    indexOne = k;
                                    m = 1;
                                }
                            }
                            houses[indexOne] = elementTwo;
                            houses[indexTwo] = elementOne;
                        }
                        
                        break;
                }
            }
            Console.WriteLine($"Position: {currPosition}");
            Console.WriteLine(String.Join(", ", houses));
        }
    }
}
