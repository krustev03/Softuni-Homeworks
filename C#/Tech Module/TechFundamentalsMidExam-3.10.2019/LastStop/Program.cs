using System;
using System.Collections.Generic;
using System.Linq;

namespace LastStop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintingNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] parts = command.Split().ToArray();
                string text = parts[0];
                if (text == "Change")
                {
                    int firstNum = int.Parse(parts[1]);
                    int secondNum = int.Parse(parts[2]);
                    if (paintingNums.Contains(firstNum))
                    {
                        for (int i = 0; i < paintingNums.Count; i++)
                        {
                            if (paintingNums[i] == firstNum)
                            {
                                paintingNums[i] = secondNum;
                                break;
                            }
                        }
                    }
                   
                }
                if (text == "Hide")
                {
                    int toHide = int.Parse(parts[1]);
                    if (paintingNums.Contains(toHide))
                    {
                        for (int i = 0; i < paintingNums.Count; i++)
                        {
                            if (paintingNums[i] == toHide)
                            {
                                paintingNums.Remove(toHide);
                            }
                        }
                    }
                    
                
                }
                if (text == "Switch")
                {
                    int firstNum = int.Parse(parts[1]);
                    int secondNum = int.Parse(parts[2]);
                    if (paintingNums.Contains(firstNum) && paintingNums.Contains(secondNum))
                    {
                        for (int i = 0; i < paintingNums.Count; i++)
                        {
                            if (paintingNums[i] == firstNum)
                            {
                                paintingNums[i] = secondNum;
                            }
                            else if (paintingNums[i] == secondNum)
                            {
                                paintingNums[i] = firstNum;
                            }
                        }
              
                    }
                }
                if (text == "Insert")
                {
                    int place = int.Parse(parts[1]);
                    int index = place + 1;
                    int num = int.Parse(parts[2]);
                    if (index >= 0 && index < paintingNums.Count)
                    {
                        paintingNums.Insert(index, num);
                      
                    }
                }
                if (text == "Reverse")
                {
                    paintingNums.Reverse();
                }
            }
            if (paintingNums.Count > 0)
            {
                Console.WriteLine(String.Join(" ", paintingNums));
            }
            
        }
    }
}
