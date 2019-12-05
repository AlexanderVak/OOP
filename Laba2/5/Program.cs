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
        }
        public void SolveWithoutRecursion()
        {
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
        public virtual void Output()
        {
            SolveWithoutRecursion();
        }


    }
    class SolveWithRecursion : Solve
    {
        double Recursive(int i, int z, double fnc,  double equation)
        {
            if (i % 2 == 0)
            {
                fnc = Math.Cos(i * X);
                z = -1;
            }
            else
            {
                fnc = Math.Sin(i * X);
                z = 1;
            }

            if (i != N)
            {


                equation += z * (((N - i) * (X - i)) / fnc);
                equation = Recursive(++i, z, fnc, equation);
            }
            return equation;
        }
        
        public override void Output()
        {
            Console.WriteLine("Recursive version = " + Recursive(1, 0, 0, 0));
        }

        public SolveWithRecursion(int n, double x)
            : base(n, x)
        {
            N = n; X = x;
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
            SolveWithRecursion rec = new SolveWithRecursion(n, x);
            Console.WriteLine(("").PadRight(40, '-'));
            eq.Output();
            Console.WriteLine(("").PadRight (40,'-'));
            rec.Output();
            Console.WriteLine(("").PadRight(40, '-'));


            Console.WriteLine("Lets check");
            double check = (((3 - 1) * (1.5 - 1)) / Math.Sin(1 * 1.5)) -
                 (((3 - 2) * (1.5 - 2)) / Math.Cos(2 * 1.5));
            Console.Write("Answer after check is " + check);
            Console.ReadKey();
        }
    }
}
