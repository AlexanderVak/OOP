using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1_4_
{
    class Program
    {
        class User
        {

            public string login;
            public string password;
            public int age;
            private string date_of_registration;
            public string Login
            {
                get { return login; }
                set { login = value; }
            }
            public string Password
            {
                get { return password; }
                set { password = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public string Date { get { return date_of_registration; } }
            public User(string log, string pw, int age)
            {
                Login = log;
                Password = pw;
                Age = age;
                date_of_registration = "27.09.2019";

            }
            public void GetInfo()
            {
                Console.WriteLine($"Login : {Login}\nPassword : {Password}\nAge : {Age}\nDate of registration : {date_of_registration}");
            }
        }

        static void Main(string[] args)
        {
            User[] users;
            User first = new User("Vasya", "1a2b", 20);
            User second = new User("Petya", "3c4d", 17);
            User third = new User("Lena", "5e6f", 23);
            User fourth = new User("Sveta", "7g8h", 19);
            User fifth = new User("Dima", "9i10j", 25);
            users = new User[] { first, second, third, fourth, fifth };
            Console.WriteLine("Please enter the number of user which is interesting for you");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    users[0].GetInfo();
                    break;
                case 2:
                    users[1].GetInfo();
                    break;
                case 3:
                    users[2].GetInfo();
                    break;
                case 4:
                    users[3].GetInfo();
                    break;
                case 5:
                    users[4].GetInfo();
                    break;
            }
            Console.ReadKey();
        }
    }
}