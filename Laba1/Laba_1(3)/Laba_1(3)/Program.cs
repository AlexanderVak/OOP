using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_3_
{
    class Point
    {
        public int x { get; }
        public int y { get; }
        public string name { get; }

        public Point(int coord_x, int coord_y, string n)
        {
            x = coord_x; y = coord_y; name = n;
        }
    }
    class Figure
    {
        Point[] point_array;
        public Figure(Point A, Point B, Point C, Point D)
        {
            point_array = new Point[] { A, B, C, D };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.x - A.x), 2) + Math.Pow((B.y - A.y), 2));
        }

        public double perimetr = 0;
        public void PerimeterCalculator()
        {
            for (int i = 0; i < point_array.Length - 1; i++)
            {
                perimetr += LengthSide(point_array[i], point_array[i + 1]);
            }
            perimetr += LengthSide(point_array[point_array.Length - 1], point_array[0]);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(3, 8, "A");
            Point B = new Point(-5, 0, "B");
            Point C = new Point(12, -3, "C");
            Point D = new Point(-4, -8, "D");
            Figure rectangle = new Figure(A, B, C, D);
            rectangle.PerimeterCalculator();
            Console.WriteLine("This is a rectangle");
            Console.WriteLine($"Perimetr is : {rectangle.perimetr}");
            Console.ReadKey();

        }
    }
}
