using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class MyMatrix
    {
        public int N { get; set; }
        public int M { get; set; }
        public int[,] matrix;

        public MyMatrix(int n, int m)
        {
            N = n;
            M = m;
            matrix = new int[N, M];
        }

        public void RandomFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    matrix[i, j] = rnd.Next(10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ResizeArray()
        {
            Console.Write("Enter new amount of rows ");
            int newRow = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new amount of columns ");
            int newCol = Convert.ToInt32(Console.ReadLine());
                        
            int[,] newArray = new int[newRow, newCol];
            int rows = 0;
            int cols = 0;

            if (newRow < N || newCol < M)
            {
                rows = Math.Min(newRow, N);
                cols = Math.Min(newCol, M);
            }
            else if (newRow > N || newCol > M)
            {
                rows = Math.Max(newRow, N);
                cols = Math.Max(newCol, M);
            }
                        
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i > N - 1 || j > M - 1)
                    {
                        newArray[i, j] = 0;
                    }
                    else
                    newArray[i, j] = matrix[i, j];
                    Console.Write(newArray[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
        public void PartOfMatrix()
        {
            Console.WriteLine("Enter index's of first point");

            Console.Write("First index: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second index: ");
            int j1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter index's of second point");

            Console.Write("First index: ");
            int i2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second index: ");
            int j2 = Convert.ToInt32(Console.ReadLine());

            for (int i = i1 - 1; i <= i2 - 1; i++)
            {
                for (int j = j1 - 1; j <= j2 - 1; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public int this[int i, int j]
        {
            get
            {
                return matrix[i - 1, j - 1];
            }
            set
            {
                matrix[i - 1, j - 1] = value;
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of rows ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount of columns ");
            int columns = Convert.ToInt32(Console.ReadLine());

            MyMatrix matrix = new MyMatrix(rows, columns);
            matrix.RandomFill();
            matrix.ResizeArray();
            matrix.PartOfMatrix();

            Console.WriteLine("Enter indexes of element");
            Console.Write("First index: ");
            int index1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second index: ");
            int index2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your element of array is - " + matrix[index1, index2]);

            Console.WriteLine("Lets change this element");
            Console.Write("Enter any number ");
            int input = Convert.ToInt32(Console.ReadLine());

            matrix[index1, index2] = input;

            Console.WriteLine("Your element of array is - " + matrix[index1, index2]);

            Console.ReadKey();

        }
    }
}