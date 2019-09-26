using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__1
{
    class Adress
    {
        public string country { get; set; } = "England";
        public string city { get; set; } = "London";
        public string street { get; set; } = "Baker Street";
        public string house { get; set; } = "221B";
        public int apartment { get; set; } = 2;
        public string index { get; set; } = "NW1 5LA";

    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress HolmesAdress = new Adress();
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} apartment, index : {5}", HolmesAdress.country, HolmesAdress.city, HolmesAdress.street, HolmesAdress.house, HolmesAdress.apartment, HolmesAdress.index);
            Console.ReadKey();
        }
    }
}
