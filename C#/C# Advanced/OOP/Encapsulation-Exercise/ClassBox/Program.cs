using System;
using System.Linq;
using System.Reflection;

namespace ClassBox
{
    class Program
    {
        public static void Main(string[] args)
        {
            Type boxType = typeof(Box);

            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            Box box = null;

            try
            {
                box = new Box(length, width, height);
            }

            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);

                return;
            }



            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():F2}");

            Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():F2}");

            Console.WriteLine($"Volume - {box.GetVolume():F2}");
        }
    }
}
