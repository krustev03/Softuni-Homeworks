using System;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int sum = 0;

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
                sum += matrix[row, row];
            }

            Console.WriteLine(sum);
        }
    }
}
