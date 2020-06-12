using System;

namespace FixingCodePartTwo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;
            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("The number is bigger value than the value byte type can handle.");
            }
        }
    }
}
