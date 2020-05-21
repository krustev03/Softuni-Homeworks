using System;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = Console.ReadLine().Split(" ");

            int rows = int.Parse(all[0]);
            int cols = int.Parse(all[1]);
            int[,] matrix = new int[rows, cols];

            int sum = 0;
            int max = int.MinValue;
            string nums = string.Empty;

            for (int row = 0; row < rows; row++)
            {
                var rowNums = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowNums[col]);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix.GetLength(0) > row + 2 && matrix.GetLength(1) > col + 2)
                    {
                        sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (sum > max)
                        {
                            max = sum;
                            nums = $"{matrix[row, col]} {matrix[row, col + 1]} {matrix[row, col + 2]}\n" +
                                   $"{matrix[row + 1, col]} {matrix[row + 1, col + 1]} {matrix[row + 1, col + 2]}\n" +
                                   $"{matrix[row + 2, col]} {matrix[row + 2, col + 1]} {matrix[row + 2, col + 2]}";
                        }
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");
            Console.WriteLine(nums);
        }
    }
}
