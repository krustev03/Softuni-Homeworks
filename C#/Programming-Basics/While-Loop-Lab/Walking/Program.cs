using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int allSteps = 0;
            int steps;
            int check = 0;
            var input = Console.ReadLine();
            while (input != "Going home")
            {
                steps = int.Parse(input);
                allSteps += steps;
                if (allSteps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    check = 1;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check == 0)
            {
                int stepsMore = int.Parse(Console.ReadLine());
                allSteps += stepsMore;
            }
            if (allSteps >= 10000 && check == 0)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            if (allSteps < 10000)
            {
                Console.WriteLine("{0} more steps to reach goal.", 10000 - allSteps);
            }
        }
    }
}
