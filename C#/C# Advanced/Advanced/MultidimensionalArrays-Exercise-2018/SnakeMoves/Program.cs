using System;
using System.Collections.Generic;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = Console.ReadLine().Split(" ");

            int rows = int.Parse(all[0]);
            int cols = int.Parse(all[1]);
            string[,] matrix = new string[rows, cols];

            string snake = Console.ReadLine();
            char[] snakeChars = snake.ToCharArray();
            Queue<char> symbols = new Queue<char>(snakeChars);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (symbols.Count == 0)
                    {
                        for (int i = 0; i < snakeChars.Length; i++)
                        {
                            symbols.Enqueue(snakeChars[i]);
                        }
                    }
                    matrix[row, col] = symbols.Dequeue().ToString();
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
