using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sumLeft = 0;
            int sumRight = 0;

            for (int row = 0; row < size; row++)
            {
                var rowNums = Console.ReadLine().Split(" ");
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = int.Parse(rowNums[col]);
                }
            }

            for (int row = 0; row < size; row++)
            {
                sumLeft += matrix[row, row];
            }

            int k = size - 1;
            for (int row = 0; row < size; row++)
            {
                sumRight += matrix[row, k];
                k--;
            }

            Console.WriteLine(Math.Abs(sumRight - sumLeft));
        }
    }
}
