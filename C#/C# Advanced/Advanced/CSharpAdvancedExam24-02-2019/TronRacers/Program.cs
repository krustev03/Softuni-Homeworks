using System;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int[] coordinatesFirst = new int[2];
            int[] coordinatesSecond = new int[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine();
                char[] fields = input.ToCharArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = fields[j];
                    if (fields[j] == 'f')
                    {
                        coordinatesFirst[0] = i;
                        coordinatesFirst[1] = j;
                    }
                    if (fields[j] == 's')
                    {
                        coordinatesSecond[0] = i;
                        coordinatesSecond[1] = j;
                    }
                }
            }

            int k = 0;
            while (k == 0)
            {
                string[] commands = Console.ReadLine().Split();
                string commandFirst = commands[0];
                string commandSecond = commands[1];

                Move(matrix, coordinatesFirst, commandFirst, k);

                if (k == 1)
                {
                    return;
                }

                Move(matrix, coordinatesSecond, commandSecond, k);
            }
        }

        static void Move(char[,] matrix, int[] coordinates, string command, int k)
        {
            char letter = matrix[coordinates[0], coordinates[1]];
            switch(command)
            {
                case "down":
                    if (coordinates[0] + 1 == matrix.GetLength(0))
                    {
                        char currField = matrix[0, coordinates[1]];
                        matrix[0, coordinates[1]] = letter;

                        coordinates[0] = 0;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[0, coordinates[1]] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        char currField = matrix[coordinates[0] + 1, coordinates[1]];
                        matrix[coordinates[0] + 1, coordinates[1]] = letter;

                        int oldCoordinates = coordinates[0];
                        coordinates[0] = coordinates[0] + 1;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[oldCoordinates + 1, coordinates[1]] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    break;
                case "up":
                    if (coordinates[0] - 1 == -1)
                    {
                        char currField = matrix[matrix.GetLength(0) - 1, coordinates[1]];
                        matrix[matrix.GetLength(0) - 1, coordinates[1]] = letter;

                        coordinates[0] = matrix.GetLength(0) - 1;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[matrix.GetLength(0) - 1, coordinates[1]] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        char currField = matrix[coordinates[0] - 1, coordinates[1]];
                        matrix[coordinates[0] - 1, coordinates[1]] = letter;

                        int oldCoordinates = coordinates[0];
                        coordinates[0] = coordinates[0] - 1;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[oldCoordinates - 1, coordinates[1]] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    break;
                case "left":
                    if (coordinates[1] - 1 == -1)
                    {
                        char currField = matrix[coordinates[0], matrix.GetLength(1) - 1];
                        matrix[coordinates[0], matrix.GetLength(1) - 1] = letter;

                        coordinates[1] = matrix.GetLength(1) - 1;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[coordinates[0], matrix.GetLength(1) - 1] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        char currField = matrix[coordinates[0], coordinates[1] - 1];
                        matrix[coordinates[0], coordinates[1] - 1] = letter;

                        int oldCoordinates = coordinates[1];
                        coordinates[1] = coordinates[1] - 1;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[coordinates[0], oldCoordinates - 1] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    break;
                case "right":
                    if (coordinates[1] + 1 == matrix.GetLength(1))
                    {
                        char currField = matrix[coordinates[0], 0];
                        matrix[coordinates[0], 0] = letter;

                        coordinates[1] = 0;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[coordinates[0], 0] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        char currField = matrix[coordinates[0], coordinates[1] + 1];
                        matrix[coordinates[0], coordinates[1] + 1] = letter;

                        int oldCoordinates = coordinates[1];
                        coordinates[1] = coordinates[1] + 1;

                        if (currField != letter && Char.IsLetter(currField) == true)
                        {
                            matrix[coordinates[0], oldCoordinates + 1] = 'x';
                            k = 1;
                            for (int i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (int j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Console.Write(matrix[i, j]);
                                }
                                Console.WriteLine();
                            }
                            Environment.Exit(0);
                        }
                    }
                    break;
            }

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
        }
    }
}
