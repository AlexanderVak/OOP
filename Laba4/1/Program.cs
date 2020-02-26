using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{

    class MyArray
    {
        public int N { get; set; }
        public int[] array;
        public MyArray(int n)
        {
            N = n;

            array = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                array[i] = rnd.Next(10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
        }
        public void MinMax()
        {
            int minValue = array.Min();
            int maxValue = array.Max();
            Console.WriteLine("\nMinimal value {0}\nMaximal value {1}", minValue, maxValue);
        }
        public void SumAndAverage()
        {
            int sumArr = 0;
            for (int i = 0; i < N; i++)
            {
                sumArr += array[i];
            }
            int avrg = sumArr / N;
            Console.WriteLine("Sum of all elements in array {0}\nAvarege of array {1}", sumArr, avrg);

        }
        public void AllOdd()
        {

            for (int i = 0; i < N; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            MyArray array = new MyArray(size);
            array.MinMax();
            array.SumAndAverage();
            Console.Write("All odd numbers in array ");
            array.AllOdd();
            Console.ReadKey();
        }
    }
}
