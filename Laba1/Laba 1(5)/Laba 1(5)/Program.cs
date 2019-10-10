using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1_5_
{
    class Converter
    {
        public double currency;
        public double Currency
        {
            set
            {
                if (currency < 0)
                    throw new Exception("Incorrect input. Currency can't be negative.");
                currency = value;
            }
            get { return currency; }
        }

        public Converter(double curr)
        {
            Currency = curr;
        }

        public double ConvertUAH(string curr)
        {
            double USD, EUR;
            if (curr == "USD")
                return USD = Currency * 0.0402;
            else if (curr == "EUR")
                return EUR = Currency * 0.0366;
            return 0;
        }
        public double ConvertUSD(string curr)
        {
            double UAH, EUR;
            if (curr == "UAH")
                return UAH = Currency * 24.8505;
            else if (curr == "EUR")
                return EUR = Currency * 0.9105;
            return 0;
        }
        public double ConvertEUR(string curr)
        {
            double USD, UAH;
            if (curr == "USD")
                return USD = Currency * 1.0982;
            else if (curr == "UAH")
                return UAH = Currency * 27.2920;
            return 0;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the currency\n(Enter UAH or USD or EUR)");
            string name_of_curr = Console.ReadLine();

            Console.WriteLine("Enter number of money");
            double num_of_curr = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Convert to ...\n(Enter USD or EUR or UAH)");
            string name_of_curr_ = Console.ReadLine();

            switch (name_of_curr)
            {
                case "UAH":
                    switch (name_of_curr_)
                    {
                        case "USD":
                            Converter uah_to_usd = new Converter(num_of_curr);
                            Console.WriteLine($"{uah_to_usd.ConvertUAH(name_of_curr_)}");
                            break;
                        case "EUR":
                            Converter uah_to_eur = new Converter(num_of_curr);
                            Console.WriteLine($"{uah_to_eur.ConvertUAH(name_of_curr_)}");
                            break;
                    }
                    break;
                case "USD":
                    switch (name_of_curr_)
                    {
                        case "UAH":
                            Converter usd_to_uah = new Converter(num_of_curr);
                            Console.WriteLine($"{usd_to_uah.ConvertUSD(name_of_curr_)}");
                            break;
                        case "EUR":
                            Converter usd_to_eur = new Converter(num_of_curr);
                            Console.WriteLine($"{usd_to_eur.ConvertUSD(name_of_curr_)}");
                            break;
                    }
                    break;
                case "EUR":
                    switch (name_of_curr_)
                    {
                        case "UAH":
                            Converter eur_to_uah = new Converter(num_of_curr);
                            Console.WriteLine($"{eur_to_uah.ConvertEUR(name_of_curr_)}");
                            break;
                        case "USD":
                            Converter eur_to_usd = new Converter(num_of_curr);
                            Console.WriteLine($"{eur_to_usd.ConvertEUR(name_of_curr_)}");
                            break;
                    }
                    break;

            }
            Console.ReadKey();
        }
    }
}


