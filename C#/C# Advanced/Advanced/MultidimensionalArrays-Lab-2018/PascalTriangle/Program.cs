using System;
using System.Numerics;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[,] matrix = new BigInteger[n, n];
       
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == 0)
                    {
                        matrix[0, 0] = 1;
                    }
                    else if (row == 1)
                    {
                        matrix[1, 0] = 1;
                        matrix[1, 1] = 1;
                    }
                    else
                    {
                        if (col == 0)
                        {
                            matrix[row, 0] = 1;
                        }
                        else
                        {
                            matrix[row, col] = matrix[row - 1, col - 1] + matrix[row - 1, col];
                        }
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] != 0)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
