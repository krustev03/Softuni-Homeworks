using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var three = int.Parse(Console.ReadLine());

            var seconds = first + second + three;
            var minutes = seconds / 60;
            var remainingSeconds = seconds - (minutes * 60);
            if (remainingSeconds < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, remainingSeconds);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, remainingSeconds);
            }
            
        }
    }
}
