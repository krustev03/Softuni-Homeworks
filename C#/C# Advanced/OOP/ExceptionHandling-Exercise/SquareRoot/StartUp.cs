using System;

namespace SquareRoot
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            EnterNumbers();
        }

        public static int ReadNumber(int start, int end)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num > end || num < start)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return num;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("The number must be in the given range.");
                return 0;
            }
        }

        public static void EnterNumbers()
        {
            int oldNum = 0;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int currNum = ReadNumber(1, 100);

                    if (i > 0)
                    {
                        if (currNum <= oldNum)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }

                    oldNum = currNum;
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Num is lower or same as the last, going from the beginning.");
                    EnterNumbers();
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("The num isn't In32, going from the beginning.");
                    EnterNumbers();
                }
            }
        }
    }
}
