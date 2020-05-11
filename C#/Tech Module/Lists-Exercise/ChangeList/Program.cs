using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                if (command == "end")
                {
                    break;
                }
                switch (tokens[0])
                {
                    case "Delete":
                        nums.RemoveAll(n => n == Convert.ToInt32(tokens[1]));
                        break;
                    case "Insert":
                        int indexToInsert = Convert.ToInt32(tokens[2]);
                        int elementToInsert = Convert.ToInt32(tokens[1]);
                        nums.Insert(indexToInsert, elementToInsert);
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
