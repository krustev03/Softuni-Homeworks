using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] field = new int[size];
            int[] ladybugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                if (ladybugs.Contains(i))
                {
                    field[i] = 1;
                }
                else
                {
                    field[i] = 0;
                }
            }
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                int index = int.Parse(command[0]);
                int moving = int.Parse(command[2]);

                if (index < 0 || index >= field.Length)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }
                else if (field[index] == 0)
                {
                    command = Console.ReadLine().Split();
                    continue;
                }

                else if (field[index] == 1)
                {
                    if (command[1] == "right")
                    {
                        index = int.Parse(command[0]);
                        moving = int.Parse(command[2]);

                        if (moving > 0)
                        {
                            MoveRight(field, index, moving);

                        }
                        else if (moving < 0)
                        {
                            MoveLeft(field, index, Math.Abs(moving));

                        }
                    }
                    else if (command[1] == "left")
                    {
                        if (moving > 0)
                        {
                            MoveLeft(field, index, moving);

                        }
                        else if (moving < 0)
                        {
                            MoveRight(field, index, Math.Abs(moving));

                        }
                    }
                    command = Console.ReadLine().Split(' ').ToArray();
                }
            }
            Console.WriteLine(String.Join(" ", field));
        }
        static void MoveRight(int[]field, int index, int moving)
        {
            field[index] = 0;
            if (!(index + moving >= field.Length))
            {
                for (int i = index + moving; i < field.Length; i+= moving)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            return;
        }
        static void MoveLeft(int[] field, int index, int moving)
        {
            field[index] = 0;
            if (!(index - moving < 0))
            {
                for (int i = index - moving; i > -1; i-= moving)
                {
                    if (field[i] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            return;
        }
    }
}
