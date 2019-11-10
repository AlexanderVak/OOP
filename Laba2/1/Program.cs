using System;

namespace _1
{
    class Pencil
    {
        private string pencil;
        public string Pencil_
        {
            get { return pencil; }
            set { pencil = value; }
        }
        public Pencil(string value)
        {
            Pencil_ = value;
        }

        public void Draw()
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
            if (Color == "blue")
                Console.ForegroundColor = ConsoleColor.Blue;
            if (Color == "green")
                Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Crayon crayon_1 = new Crayon("Red pencil", "red");
            Pencil pencil_1 = crayon_1;
            pencil_1.Draw();

            Crayon crayon_2 = new Crayon("Blue pencil", "blue");
            Pencil pencil_2 = crayon_2;
            pencil_2.Draw();

            Crayon crayon_3 = new Crayon("Wake up, Neo...", "green");
            Pencil pencil_3 = crayon_3;
            pencil_3.Draw();

            Console.ReadKey();
        }
    }
}
