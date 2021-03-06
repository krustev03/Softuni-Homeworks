﻿using System;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            var all = Console.ReadLine().Split(", ");
            int rows = int.Parse(all[0]);
            int cols = int.Parse(all[1]);

            int[,] matrix = new int[rows, cols];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                var rowNums = Console.ReadLine().Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowNums[col]);
                    sum += int.Parse(rowNums[col]);
                }
            }

            for (int col = 0; col < cols; col++)
            {
                sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
