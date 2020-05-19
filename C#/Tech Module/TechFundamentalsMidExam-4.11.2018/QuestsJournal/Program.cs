using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestsJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.None).ToList();
            string command;
            while ((command = Console.ReadLine()) != "Retire!")
            {
                string[] parts = command.Split(new string[] { " - " }, StringSplitOptions.None).ToArray();
                if (parts[0] == "Start")
                {
                    if (!(quests.Contains(parts[1])))
                    {
                        quests.Add(parts[1]);
                    }
                }
                if (parts[0] == "Complete")
                {
                    if (quests.Contains(parts[1]))
                    {
                        quests.Remove(parts[1]);
                    }
                }
                if (parts[0] == "Side Quest")
                {
                    string[] sideQuest = parts[1].Split(':').ToArray();
                    if (quests.Contains(sideQuest[0]) && !(quests.Contains(sideQuest[1])))
                    {
                        for (int i = 0; i < quests.Count; i++)
                        {
                            if (quests[i] == sideQuest[0])
                            {
                                quests.Insert(i + 1, sideQuest[1]);
                            }
                        }
                    }
                }
                if (parts[0] == "Renew")
                {
                    if (quests.Contains(parts[1]))
                    {
                        quests.Remove(parts[1]);
                        quests.Add(parts[1]);
                    }
                }
            }
            Console.WriteLine(String.Join(", ", quests));
        }
    }
}
