using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (true)
            {
                var number = Console.ReadLine();
                if (number == "stop")
                {
                    break;
                }
                bool prime = true;
                if (Convert.ToInt32(number) < 3)
                {
                    if (Convert.ToInt32(number) == 2)
                    {
                        sumPrime += Convert.ToInt32(number);
                    }
                    else
                    {
                        if (Convert.ToInt32(number) < 0)
                        {
                            Console.WriteLine("Number is negative.");
                        }
                        else if (Convert.ToInt32(number) == 1)
                        {
                            sumNonPrime += Convert.ToInt32(number);
                        }
                    }
                }
                else
                {
                    for (int i = 2; i < Convert.ToInt32(number); i++)
                    {
                        if (Convert.ToInt32(number) % i == 0)
                        {
                            prime = false;
                        }
                    }
                    if (prime == true)
                    {
                        sumPrime += Convert.ToInt32(number);
                    }
                    if (prime == false)
                    {
                        sumNonPrime += Convert.ToInt32(number);
                    }
                }
                if (number == "stop")
                {
                    break;
                }
            }
            Console.WriteLine("Sum of all prime numbers is: {0}", sumPrime);
            Console.WriteLine("Sum of all non prime numbers is: {0}", sumNonPrime);
        }
    }
}
