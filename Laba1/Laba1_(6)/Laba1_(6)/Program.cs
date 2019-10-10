using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1__6_
{
    class Function
    {
        double firstX, lastX, step;
        double[][] array;
        public double FirstX
        {
            get { return firstX; }
            set { firstX = value; }
        }
        public double LastX
        {
            get { return lastX; }
            set { lastX = value; }
        }
        public double Step
        {
            set
            {
                if (step < 0)
                {
                    throw new Exception(" Incorrect input! Step can't be negative. ");
                }
            }
            get { return step; }
        }
        public double[][] Array
        {

            set
            {
                int size = (int)((LastX - FirstX) / Step);
                double x = FirstX;
                for (int i = 0; i < size + 1; i++)
                {
                    if (x >= -10 && x < -5)
                    {
                        array[i] = new double[1] { x };
                    }
                    else if (x <= -10)
                    {
                        double fn1 = Math.Tan(Math.Sqrt(Math.Sin(x) - 0.2));
                        array[i] = new double[2] { x, fn1 };
                    }
                    else if (x > -5)
                    {
                        double fn2 = Math.Acos(Math.Sqrt(Math.Log(9 - (x * x))));
                        array[i] = new double[2] { x, fn2 };
                    }
                    x += Step;
                }

            }
            get { return array; }
        }
        public Function(double firstX, double lastX, double step)
        {
            FirstX = firstX;
            LastX = lastX;
            Step = step;
            Array = new double [];
        }
        public void GetInfo()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(string.Join(" || ", Array[i]));
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the begining of interval");
            double firstX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the end of interval");
            double lastX = Convert.ToDouble(Console.ReadLine());
            double step = Convert.ToDouble(Console.ReadLine());
            Function fn = new Function(firstX, lastX, step);
            fn.GetInfo();
            Console.ReadKey();

        }
    }
}


