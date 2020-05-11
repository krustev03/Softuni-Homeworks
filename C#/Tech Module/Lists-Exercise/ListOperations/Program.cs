using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
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
                if (command == "End")
                {
                    break;
                }
                switch (tokens[0])
                {
                    case "Remove":
                        int index = Convert.ToInt32(tokens[1]);
                        if (index < 0 || index > nums.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.RemoveAt(index);
                        }
                        break;
                    case "Insert":
                        int indexToInsert = Convert.ToInt32(tokens[2]);
                        int elementToInsert = Convert.ToInt32(tokens[1]);
                        if (indexToInsert < 0 || indexToInsert > nums.Count - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.Insert(indexToInsert, elementToInsert);
                        }
                        break;
                    case "Add":
                        nums.Add(Convert.ToInt32(tokens[1]));
                        break;
                    case "Shift":
                        if (tokens[1] == "right")
                        {
                            for (int i = 0; i < Convert.ToInt32(tokens[2]); i++)
                            {
                                nums.Insert(0, nums[nums.Count - 1]);
                                nums.RemoveAt(nums.Count - 1);
                            }
                        }
                        if (tokens[1] == "left")
                        {
                            for (int i = 0; i < Convert.ToInt32(tokens[2]); i++)
                            {
                                nums.Add(nums[0]);
                                nums.RemoveAt(0);
                            }
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", nums));
        }
    }
}
