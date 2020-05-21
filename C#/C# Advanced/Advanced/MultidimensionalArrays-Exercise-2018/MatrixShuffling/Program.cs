using System;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = Console.ReadLine().Split(" ");

            int rows = int.Parse(all[0]);
            int cols = int.Parse(all[1]);
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var rowNums = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowNums[col];
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var parts = input.Split();

                if (
                   parts.Length == 5 &&
                   parts[0] == "swap" &&
                   int.Parse(parts[1]) < matrix.GetLength(0) &&
                   int.Parse(parts[1]) >= 0 &&
                   int.Parse(parts[2]) < matrix.GetLength(1) &&
                   int.Parse(parts[2]) >= 0 &&
                   int.Parse(parts[3]) < matrix.GetLength(0) &&
                   int.Parse(parts[3]) >= 0 &&
                   int.Parse(parts[4]) < matrix.GetLength(1) &&
                   int.Parse(parts[4]) >= 0
                   )
                {
                    int row1 = int.Parse(parts[1]);
                    int col1 = int.Parse(parts[2]);
                    int row2 = int.Parse(parts[3]);
                    int col2 = int.Parse(parts[4]);

                    string change = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = change;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
