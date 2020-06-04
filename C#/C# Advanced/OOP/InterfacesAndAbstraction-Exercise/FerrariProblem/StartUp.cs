using System;

namespace FerrariProblem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string driver = Console.ReadLine();

            Ferrari ferrari = new Ferrari(driver);

            Console.WriteLine($@"{ferrari.Model}/{ferrari.UseBrakes()}/{ferrari.PushGas()}/{ferrari.Driver}");
        }
    }
}
