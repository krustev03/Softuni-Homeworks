using System;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var str = Console.ReadLine();
                if (str == "end")
                {
                    break;
                }
                string reversed = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reversed += str[i];
                }
                Console.WriteLine($"{str} = {reversed}");
            }
        }
    }
}
