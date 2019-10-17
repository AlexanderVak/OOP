
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
                else
                    step = value;
            }
            get { return step; }
        }
        public double[][] Array
        {
            set { array = value; }
            get { return array; }
        }
        public int GetSize()
        {
            int size = (int)((LastX - FirstX) / Step);
            return size + 1;
        }
        public void Calculate()
        {

            double x = FirstX;
            for (int i = 0; i < GetSize(); i++)
            {
                if (x > -10 && x <= -5)
                {
                    Array[i] = new double[1] { x };
                }
                else if (x <= -10)
                {
                    double tmp_fn = Math.Sin(x) - 0.2;
                    double tmp_fn_ = Math.Sqrt(tmp_fn);
                    double fn1 = Math.Tan(tmp_fn_);
                    if (tmp_fn < 0)
                        Array[i] = new double[1] { x };

                    else if (tmp_fn_ == Math.PI / 2 || tmp_fn_ == (3 * Math.PI) / 2)
                        Array[i] = new double[1] { x };

                    else
                        Array[i] = new double[2] { x, fn1 };
                }
                else if (x > -5)
                {
                    double tmp_fn = Math.Sqrt(Math.Log(9 - (x * x)));
                    double fn2 = Math.Acos(tmp_fn);
                    if (tmp_fn <= 1 && tmp_fn >= -1)
                        Array[i] = new double[2] { x, fn2 };
                    else
                        Array[i] = new double[1] { x };


                }
                x += Step;
            }
        }
        public Function(double firstX, double lastX, double step)
        {
            FirstX = firstX;
            LastX = lastX;
            Step = step;
            Array = new double[GetSize()][];
        }
        public void GetInfo()
        {
            Calculate();
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine(string.Join(" _ ", Array[i]));
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
            Console.WriteLine("Enter the step of interval");
            double step = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Function fn = new Function(firstX, lastX, step);
            fn.GetInfo();
            Console.ReadKey();

        }
    }
}