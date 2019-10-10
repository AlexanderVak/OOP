using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__1
{
    class Adress
    {
        public string country;
        public string city;
        public string street;
        public string house;
        public int apartment;
        public string index;

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        public string House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public Adress(string country, string city, string street, string house, int apartment, string index)
        {
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
            Index = index;
        }

    
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Adress HolmesAdress = new Adress("England", "London", "Baker Street", "221B", 2, "NW1 5LA");
            Console.WriteLine("{0}, {1}, {2}, {3}, {4} apartment, index : {5}", HolmesAdress.country, HolmesAdress.city, HolmesAdress.street, HolmesAdress.house, HolmesAdress.apartment, HolmesAdress.index);
            Console.ReadKey();
        }
    }
}
