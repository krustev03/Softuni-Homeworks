using System;
using System.Linq;
using System.Collections.Generic;

namespace ExcelFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] table = new string[n, n - 1];

            string[] header = new string[n - 1];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(", ");
                for (int j = 0; j < n - 1; j++)
                {
                    if (i == 0)
                    {
                        header[j] = input[j];
                    }
                    table[i, j] = input[j];
                }
            }

            

            var command = Console.ReadLine().Split();

            switch(command[0])
            {
                case "hide":
                    Hide(table, command[1], n, header);
                    break;
                case "sort":
                    Sort(table, command[1], n, header);
                    break;
                case "filter":
                    break;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - 1; j++)
            //    {
            //        Console.Write(table[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }

        public static void Hide(string[,] table, string column, int n, string[] header)
        {
            string[,] newTable = new string[n, n - 2];
            int index = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (header[i] == column)
                {
                    index = i;
                }
            }

            int c = 0;

            for (int i = 0; i < n; i++)
            {
                c = 0;
                for (int j = 0; j < n - 1; j++)
                {
                    if (j != index)
                    {
                        newTable[i, c] = table[i, j];
                        c++;
                    }               
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 2; j++)
                {
                    if (j != newTable.GetLength(1) - 1)
                    {
                        Console.Write(newTable[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(newTable[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Sort(string[,] table, string column, int n, string[] header)
        {
            string[,] newTable = new string[n, n - 1];

            int index = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (header[i] == column)
                {
                    index = i;
                }
            }

            List<string> values = new List<string>();

            for (int i = 1; i < n; i++)
            {
                values.Add(table[i, index]);
            }
            values.Sort();
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        newTable[i, j] = table[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        newTable[i, j] = table[i, j];
                    }
                }
            }

            
        }
    }
}
