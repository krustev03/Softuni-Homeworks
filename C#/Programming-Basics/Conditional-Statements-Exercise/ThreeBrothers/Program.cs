using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeFirstSon = double.Parse(Console.ReadLine());
            var timeSecondSon = double.Parse(Console.ReadLine());
            var timeThirdSon = double.Parse(Console.ReadLine());
            var fatherFishingTime = double.Parse(Console.ReadLine());

            var totalCleaningTime = (1 / (1 / timeFirstSon + 1 / timeSecondSon + 1 / timeThirdSon)) * 1.15;

            if (totalCleaningTime <= fatherFishingTime)
            {
                Console.WriteLine($"Cleaning time: {totalCleaningTime:f2}");
                var timeLeft = Math.Floor(Math.Abs(totalCleaningTime - fatherFishingTime));
                Console.WriteLine($"Yes, there is a surprise - time left -> {timeLeft} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {totalCleaningTime:f2}");
                var timeLeft = Math.Ceiling(Math.Abs(totalCleaningTime - fatherFishingTime));
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {timeLeft} hours.");
            }
        }
    }
}
