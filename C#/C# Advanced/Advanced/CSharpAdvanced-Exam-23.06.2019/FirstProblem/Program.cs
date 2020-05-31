using System;
using System.Linq;
using System.Collections.Generic;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int currRow = 0;
            int currCol = 0;
            int starPower = 0;

            for (int i = 0; i < size; i++)
            {
                var input = Console.ReadLine();
                char[] row = input.ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                    if (matrix[i, j] == 'S')
                    {
                        currRow = i;
                        currCol = j;
                    }
                }
            }

            bool lost = false;
            int k = 0;

            while (k == 0)
            {
                var command = Console.ReadLine();

                switch(command)
                {
                    case "up":
                        matrix[currRow, currCol] = '-';
                        if (currRow - 1 < 0)
                        {
                            lost = true;
                            k = 1;
                        }
                        else
                        {
                            currRow = currRow - 1;

                            if (Char.IsDigit(matrix[currRow, currCol]) == true)
                            {
                                string num = matrix[currRow, currCol].ToString();
                                starPower += int.Parse(num);
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int i = 0; i < size; i++)
                                {
                                    for (int j = 0; j < size; j++)
                                    {
                                        if (matrix[i, j] == 'O')
                                        {
                                            currRow = i;
                                            currCol = j;
                                        }
                                    }
                                }
                            }

                            matrix[currRow, currCol] = 'S';
                        }
                        break;
                    case "down":
                        matrix[currRow, currCol] = '-';
                        if (currRow + 1 == matrix.GetLength(0))
                        {
                            lost = true;
                            k = 1;
                        }
                        else
                        {
                            currRow = currRow + 1;

                            if (Char.IsDigit(matrix[currRow, currCol]) == true)
                            {
                                string num = matrix[currRow, currCol].ToString();
                                starPower += int.Parse(num);
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int i = 0; i < size; i++)
                                {
                                    for (int j = 0; j < size; j++)
                                    {
                                        if (matrix[i, j] == 'O')
                                        {
                                            currRow = i;
                                            currCol = j;
                                        }
                                    }
                                }
                            }

                            matrix[currRow, currCol] = 'S';
                        }
                        break;
                    case "right":
                        matrix[currRow, currCol] = '-';
                        if (currCol + 1 == matrix.GetLength(1))
                        {
                            lost = true;
                            k = 1;
                        }
                        else
                        {
                            currCol = currCol + 1;

                            if (Char.IsDigit(matrix[currRow, currCol]) == true)
                            {
                                string num = matrix[currRow, currCol].ToString();
                                starPower += int.Parse(num);
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int i = 0; i < size; i++)
                                {
                                    for (int j = 0; j < size; j++)
                                    {
                                        if (matrix[i, j] == 'O')
                                        {
                                            currRow = i;
                                            currCol = j;
                                        }
                                    }
                                }
                            }

                            matrix[currRow, currCol] = 'S';
                        }
                        break;
                    case "left":
                        matrix[currRow, currCol] = '-';
                        if (currCol - 1 < 0)
                        {
                            lost = true;
                            k = 1;
                        }
                        else
                        {
                            currCol = currCol - 1;

                            if (Char.IsDigit(matrix[currRow, currCol]) == true)
                            {
                                string num = matrix[currRow, currCol].ToString();
                                starPower += int.Parse(num);
                            }
                            else if (matrix[currRow, currCol] == 'O')
                            {
                                matrix[currRow, currCol] = '-';
                                for (int i = 0; i < size; i++)
                                {
                                    for (int j = 0; j < size; j++)
                                    {
                                        if (matrix[i, j] == 'O')
                                        {
                                            currRow = i;
                                            currCol = j;
                                        }
                                    }
                                }
                            }

                            matrix[currRow, currCol] = 'S';
                        }
                        break;
                }

                if (starPower >= 50)
                {
                    k = 1;
                }
            }

            if (lost)
            {
                Console.WriteLine("Bad news, the spaceship went to the void.");
            }
            else
            {
                Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
            }

            Console.WriteLine($"Star power collected: {starPower}");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
