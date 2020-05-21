using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            bool firstOccurance = false;
            string coordinates = string.Empty;

            for (int row = 0; row < size; row++)
            {
                string rowStr = Console.ReadLine();
                char[] rowChar = rowStr.ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = rowChar[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == symbol && firstOccurance == false)
                    {
                        coordinates = "(" + row + ", " + col + ")";
                        Console.WriteLine(coordinates);
                        firstOccurance = true;
                        break;
                    }
                }
            }

            if (firstOccurance == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
