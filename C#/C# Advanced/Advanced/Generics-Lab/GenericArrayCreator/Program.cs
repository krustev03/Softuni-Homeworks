using System;

namespace GenericArrayCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = ArrayCreator<int>.Create(10, 33);
        }
    }
}
