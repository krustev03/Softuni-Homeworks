using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Resources/01. Odd Lines/Input.txt"))
            {
                int counter = 0;

                string line = "";

                while(line != null)
                {
                    line = reader.ReadLine();

                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line); ;
                    }

                    counter++;
                }
            }
        }
    }
}
