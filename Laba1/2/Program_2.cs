
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_2_
{
    class Circle
    {
        double x, y, r;
        public Circle(double X, double Y, double R)
        {
            x = X; y = Y; r = R;
        }
        public int GetQuadrant()
        {
            int result = 0;

            if (x > 0 && y > 0) { result = 1; }
            if (x < 0 && y > 0) { result = 2; }
            if (x < 0 && y < 0) { result = 3; }
            if (x > 0 && y < 0) { result = 4; }

            return result;
        }
        public double AreaCalc()
        {
            double area = Math.PI * (r * r);
            return area;
        }
        public double PerimeterCalc()
        {
            double perimeter = 2 * Math.PI * r;
            return perimeter;
        }

        public int Quadrant { get { return GetQuadrant(); } }
        public double Area { get { return AreaCalc(); } }
        public double Perimeter { get { return PerimeterCalc(); } }

        public void Output()
        {
            Console.WriteLine($"Quadrant : {Quadrant}; Area : {Area}; Perimeter : {Perimeter}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinats and radius");
            double coordinat_x = Convert.ToDouble(Console.ReadLine());
            double coordinat_y = Convert.ToDouble(Console.ReadLine());
            double rad = Convert.ToDouble(Console.ReadLine());

            Circle newSircle = new Circle(coordinat_x, coordinat_y, rad);
            newSircle.Output();
            Console.ReadKey();
        }
    }
}