using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_2._5
{
    class Solve
    {
        int n;
        double x;
        public int N
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Wrong input! N must be natural number");
                else
                    n = value;
            }
            get { return n; }
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public Solve(int n, double x)
        {
            N = n; X = x;
            double equation = 0;
            for (int i = 1; i < N; i++)
            {
                equation *= -1;
                double fnc = 0;
                if (i % 2 == 0)
                    fnc = Math.Cos(i * X);
                else
                    fnc = Math.Sin(i * X);

                equation -= ((N - i) * (X - i)) / fnc;

            }

            Console.WriteLine("The answer is : {0}", equation);
        }

    }
    class SolveWithRecursion:Solve
    {
        public SolveWithRecursion()
           
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number n : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number x : ");
            double x = Convert.ToDouble(Console.ReadLine());


            Solve eq = new Solve(n, x);

            Console.WriteLine("Lets check");
            double check = (((3 - 1) * (1.5 - 1)) / Math.Sin(1 * 1.5)) -
                 (((3 - 2) * (1.5 - 2)) / Math.Cos(2 * 1.5)) ;
            Console.Write("Answer after check is " + check);
            Console.ReadKey();
        }
    }
}
