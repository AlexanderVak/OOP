using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pencil
    {
        private string pencil;
        public string Pencil_
        {
            get { return pencil; }
            set { pencil = value; }
        }
        public Pencil (string value)
        {
            Pencil_ = value;
        }

        void Draw()
        {
            Console.WriteLine(Pencil_);
        }
    }
    class Crayon : Pencil
    {
        public string Color { get; set; }
        public Crayon(string pencil, string color)
            : base(pencil)
        {
            Color = color;
            if (Color == "red")
                Console.ForegroundColor = ConsoleColor.Red;
            if(Color == "blue")
                Console.ForegroundColor = ConsoleColor.Blue;
            if (Color == "green")
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
