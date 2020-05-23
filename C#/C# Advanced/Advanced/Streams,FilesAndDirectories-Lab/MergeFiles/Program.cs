using System;
using System.IO;

namespace MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] readFirst = File.ReadAllText("FileOne.txt").Split('\r', '\n');
            string[] readSecond = File.ReadAllText("FileTwo.txt").Split('\r', '\n');
            File.WriteAllText("result.txt", "");
            for (int i = 0; i < readFirst.Length; i++)
            {
                File.AppendAllText("result.txt", readFirst[i] + "\r\n" + readSecond[i]);
            }
            using (var reader = new StreamReader("result.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    Console.WriteLine(line);
                }
            }
        }
    }
}
