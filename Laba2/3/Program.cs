using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        class Vehicle
        {
            string price;
            string speed;
            string year;
            public string Price
            {
                get { return price; }
                set { price = value; }
            }
            public string Speed
            {
                get { return speed; }
                set { speed = value; }
            }
            public string Year
            {
                get { return year; }
                set { year = value; }
            }

            public Vehicle(string price, string speed, string year)
            {
                Price = price;
                Speed = speed;
                Year = year;
            }
            public void Output()
            {
                Console.Write($"Price of the vehicle - {Price};" +
                    $"\nSpeed of the vehicle - {Speed};" +
                    $"\nYear of issue of the vehicle - {Year};");
            }
        }
        class Plane : Vehicle
        {
            public int Hight { get; set; }
            public int Passengers { get; set; }
            public Plane(string price, string speed, string year, int hight, int passangers)
                : base(price, speed, year)
            {
                Hight = hight;
                Passengers = passangers;


            }
            public new void Output()
            {
                Console.Write($"Price of the vehicle - {Price};" +
                    $"\nSpeed of the vehicle {Speed};" +
                    $"\nYear of issue of the vehicle - {Year};" +
                    $"\nHight of the flight - {Hight} feet;" +
                    $"\nQuantity of passebgers - {Passengers};");

            }
        }
        class Car : Vehicle
        {
            public Car(string price, string speed, string year)
                : base(price, speed, year)
            {
                Output();
            }
        }
        class Ship : Vehicle
        {
            public int Passengers { get; set; }
            public string Port { get; set; }
            public Ship(string price, string speed, string year, int passengers, string port)
                : base(price, speed, year)
            {
                Passengers = passengers;
                Port = port;
            }
            public new void Output()
            {
                Console.Write($"Price of the vehicle - {Price};" +
                    $"\nSpeed of the vehicle - {Speed};" +
                    $"\nYear of issue of the vehicle - {Year};" +
                    $"\nQuantity of passebgers - {Passengers};" +
                    $"\nHome port - {Port}");

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your type of transport (Plane or Car or Ship)");
            string input = Console.ReadLine();
            Console.WriteLine();
            switch (input)
            {
                case "Plane":
                    {
                        Plane p = new Plane("$74 million", "470 ktas", "1996", 39000, 149);
                        p.Output();
                    }
                    break;
                case "Car":
                    {
                        Car c = new Car("$70.000", "80 km/h", "2012");
                    }
                    break;
                case "Ship":
                    {
                        Ship s = new Ship("$7.5 million", "42.6 km/h", "1911", 2223, "Southampton");
                        s.Output();
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
