using System;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = Console.ReadLine().Split(" ");

            int rows = int.Parse(all[0]);
            int cols = int.Parse(all[1]);
            char[,] matrix = new char[rows, cols];

            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                var rowChars = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(rowChars[col]);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix.GetLength(0) > row + 1 && matrix.GetLength(1) > col + 1)
                    {
                        if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col + 1] == matrix[row + 1, col] && matrix[row + 1, col] == matrix[row + 1, col + 1])
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
