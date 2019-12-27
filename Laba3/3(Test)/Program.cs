using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Test_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxCount = 0;

            int[] temperature = new int[4];
            int[] jmax = new int[4];
            int[] date = new int[5];
            int[,] table = {
                { -5, -10, -3, -3 },
                { -3, -7, -8, -6 },
                { -5, 2, 2, 2  }
            };
            Console.WriteLine(table.GetLength(1));
            int count = 0;
            for (int i = 0; i < table.GetLength(1); i++)
            {
                count = 0;
                for (int j = 0; j < table.GetLength(0); j++)
                {
                    if (table[i, j] == table[i, j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        if (count > maxCount)
                        {
                            maxCount = count;
                            temperature[i] = table[i, j];
                            date[j] = j++;
                        }


                    }
                    count = 0;
                }

            }
            Console.ReadKey();
        }
    }
}
