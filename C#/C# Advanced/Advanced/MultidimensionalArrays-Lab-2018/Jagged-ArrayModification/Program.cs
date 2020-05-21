using System;

namespace Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                var rowNums = Console.ReadLine().Split(" ");
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = int.Parse(rowNums[col]);
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

                string command = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                switch (command)
                {
                    case "Add":
                        if (
                            row < matrix.GetLength(0) &&
                            row >= 0 &&
                            col < matrix.GetLength(1) &&
                            col >= 0
                            )
                        {
                            matrix[row, col] += value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;

                    case "Subtract":
                        if (
                            row < matrix.GetLength(0) &&
                            row >= 0 &&
                            col < matrix.GetLength(1) &&
                            col >= 0
                        )
                        {
                            matrix[row, col] -= value;
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;
                }

            }

            for (int rowMatrix = 0; rowMatrix < size; rowMatrix++)
            {
                for (int colMatrix = 0; colMatrix < size; colMatrix++)
                {
                    Console.Write(matrix[rowMatrix, colMatrix] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
