using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            double bonus;
            if (num <= 100)
            {
                bonus = 5;
                double finalNum = num + bonus;
                if (num % 2 == 0)
                {
                    bonus = bonus + 1;
                    finalNum = num + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
               else if (num % 10 == 5)
                {
                    bonus = bonus + 2;
                    finalNum = num + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
            }
            else if (num > 100 && num < 1000)
            {
                bonus = num * 0.20;
                double finalNum = num + bonus;
                if (num % 2 == 0)
                {
                    bonus = bonus + 1;
                    finalNum = num + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
                else if (num % 10 == 5)
                {
                    bonus = bonus + 2;
                    finalNum = num + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
            }
            else if (num > 1000)
            {
                bonus = num * 0.10;
                double finalNum = num + bonus;
                if (num % 2 == 0)
                {
                    bonus = bonus + 1;
                    finalNum = num + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
                else if (num % 10 == 5)
                {
                    bonus = bonus + 2;
                    finalNum = num + bonus;
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
                else
                {
                    Console.WriteLine(bonus);
                    Console.WriteLine(finalNum);
                }
            }
        }
    }
}
