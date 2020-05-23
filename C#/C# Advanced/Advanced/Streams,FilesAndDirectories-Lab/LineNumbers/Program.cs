using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("Resources/02. Line Numbers/Input.txt"))
            {
                int counter = 1;

                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    Console.WriteLine($"{counter}. {line}");

                    counter++;
                }
            }
        }
    }
}
