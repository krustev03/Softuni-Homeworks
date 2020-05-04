using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MinValue;
            string winner = string.Empty;
            while (true)
            {
                double sum = 0;
                string name = Console.ReadLine();
                if (name == "STOP")
                {
                    break;
                }
                for (int i = 0; i < name.Length; i++)
                {
                    sum += (int)name[i];
                }
                if (sum > max)
                {
                    max = sum;
                    winner = name;
                }
            }
            Console.WriteLine("Winner is {0} - {1}!", winner, max);
        }
    }
}
