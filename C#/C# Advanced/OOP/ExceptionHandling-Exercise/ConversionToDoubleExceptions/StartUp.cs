using System;

namespace ConversionToDoubleExceptions
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var value = Console.ReadLine();
            double result;

            try
            {
                result = Convert.ToDouble(value);
                Console.WriteLine("Converted '{0}' to {1}.", value, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", value);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", value);
            }
        }
    }
}
