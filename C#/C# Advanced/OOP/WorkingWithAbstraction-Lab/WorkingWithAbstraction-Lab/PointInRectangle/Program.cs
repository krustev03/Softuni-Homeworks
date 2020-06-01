using System;
using System.Linq;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinatesOfRectangle = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point topLeft = new Point(coordinatesOfRectangle[0], coordinatesOfRectangle[1]);
            Point bottomRight = new Point(coordinatesOfRectangle[2], coordinatesOfRectangle[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var coordinatesOfPoint = Console.ReadLine().Split().Select(int.Parse).ToArray();

                Point currPoint = new Point(coordinatesOfPoint[0], coordinatesOfPoint[1]);

                Console.WriteLine(rectangle.Contains(currPoint));
            }
        }
    }
}
