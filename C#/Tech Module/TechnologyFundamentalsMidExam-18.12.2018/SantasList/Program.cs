using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantasList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> kids = Console.ReadLine().Split('&').ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Finished!")
                {
                    break;
                }
                string[] parts = command.Split().ToArray();
                switch (parts[0])
                {
                    case "Bad":
                        if (!(kids.Contains(parts[1])))
                        {
                            kids.Insert(0, parts[1]);
                        }
                        break;
                    case "Good":
                        if (kids.Contains(parts[1]))
                        {
                            kids.Remove(parts[1]);
                        }
                        break;
                    case "Rename":
                        string oldName = parts[1];
                        string newName = parts[2];
                        for (int i = 0; i < kids.Count; i++)
                        {
                            if (kids[i] == oldName)
                            {
                                kids[i] = newName;
                            }
                        }
                        break;
                    case "Rearrange":
                        if (kids.Contains(parts[1]))
                        {
                            kids.Remove(parts[1]);
                            kids.Add(parts[1]);
                        }
                        break;
                }
            }
            Console.WriteLine(String.Join(", ", kids));
        }
    }
}
