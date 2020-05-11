using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());
            while(true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    if (tokens[0] == "Add")
                    {
                        vagons.Add(Convert.ToInt32(tokens[1]));
                    }
                    else if (Convert.ToInt32(tokens[0]) % 1 == 0)
                    {
                        for (int i = 0; i < vagons.Count; i++)
                        {
                            if (vagons[i] + Convert.ToInt32(tokens[0]) <= capacity)
                            {
                                vagons[i] += Convert.ToInt32(tokens[0]);
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(String.Join(" ", vagons));
        }
    }
}
