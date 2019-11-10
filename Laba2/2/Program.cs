using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Group
    {
        int[] group_arr;
        public int[] Group_arr { get { return group_arr; } set { group_arr = value; } }
        public Group(int[] gr_arr)
        {
            Group_arr = gr_arr;
            int gr_num = 0;
            int fr_gr = Group_arr[0];
            int sec_gr = Group_arr[1];
            int third_gr = Group_arr[2];
            int length = Group_arr.Length;

            Student stud1_g1 = new Student("Petro", "10-A", 4);
            Student stud2_g1 = new Student("Olena", "10-A", 5);
            Student stud3_g1 = new Student("Dima", "10-A", 3);
            Student stud4_g1 = new Student("Kate", "10-A", 4);

            Student stud1_g2 = new Student("Vika", "10-B", 5);
            Student stud2_g2 = new Student("Oleg", "10-B", 3);
            Student stud3_g2 = new Student("Bohdan", "10-B", 3);
            Student stud4_g2 = new Student("Kostya", "10-B", 4);

            Student stud1_g3 = new Student("Ihor", "10-C", 5);
            Student stud2_g3 = new Student("Ivan", "10-C", 5);
            Student stud3_g3 = new Student("Max", "10-C", 4);
            Student stud4_g3 = new Student("Ira", "10-C", 4);

            switch (length)
            {
                case 1:
                    {
                        if (gr_num == fr_gr)
                        {
                            Console.WriteLine("Group #1");
                            stud1_g1.Output();
                            stud1_g1.Study();
                            stud1_g1.Programming();
                            stud1_g1.PlayFootball();
                            Console.WriteLine();
                            stud2_g1.Output();
                            stud2_g1.Study();
                            stud2_g1.Programming();
                            stud2_g1.PlayFootball();
                            Console.WriteLine();
                            stud3_g1.Output();
                            stud3_g1.Study();
                            stud3_g1.Programming();
                            stud3_g1.PlayFootball();
                            Console.WriteLine();
                            stud4_g1.Output();
                            stud4_g1.Study();
                            stud4_g1.Programming();
                            stud4_g1.PlayFootball();

                        }
                        else if (gr_num == sec_gr)
                        {

                            Console.WriteLine("Group #2");
                            stud1_g2.Output();
                            stud1_g2.Study();
                            stud1_g2.Programming();
                            stud1_g2.PlayFootball();
                            Console.WriteLine();
                            stud2_g2.Output();
                            stud2_g2.Study();
                            stud2_g2.Programming();
                            stud2_g2.PlayFootball();
                            Console.WriteLine();
                            stud3_g2.Output();
                            stud3_g2.Study();
                            stud3_g2.Programming();
                            stud3_g2.PlayFootball();
                            Console.WriteLine();
                            stud4_g2.Output();
                            stud4_g2.Study();
                            stud4_g2.Programming();
                            stud4_g2.PlayFootball();
                        }
                        else if (gr_num == third_gr)
                        {
                            Console.WriteLine("Group #3");
                            stud1_g3.Output();
                            stud1_g3.Study();
                            stud1_g3.Programming();
                            stud1_g3.PlayFootball();
                            Console.WriteLine();
                            stud2_g3.Output();
                            stud2_g3.Study();
                            stud2_g3.Programming();
                            stud2_g3.PlayFootball();
                            Console.WriteLine();
                            stud3_g3.Output();
                            stud3_g3.Study();
                            stud3_g3.Programming();
                            stud3_g3.PlayFootball();
                            Console.WriteLine();
                            stud4_g3.Output();
                            stud4_g3.Study();
                            stud4_g3.Programming();
                            stud4_g3.PlayFootball();
                        }
                        else
                            Console.WriteLine("Such group doesn't exist!");
                    }
                    break;
                case 2:
                    {
                        if (fr_gr + sec_gr == 3)
                        {
                            Console.WriteLine("Group #1");
                            stud1_g1.Output();
                            stud1_g1.Study();
                            stud1_g1.Programming();
                            stud1_g1.PlayFootball();
                            Console.WriteLine();
                            stud2_g1.Output();
                            stud2_g1.Study();
                            stud2_g1.Programming();
                            stud2_g1.PlayFootball();
                            Console.WriteLine();
                            stud3_g1.Output();
                            stud3_g1.Study();
                            stud3_g1.Programming();
                            stud3_g1.PlayFootball();
                            Console.WriteLine();
                            stud4_g1.Output();
                            stud4_g1.Study();
                            stud4_g1.Programming();
                            stud4_g1.PlayFootball();
                            Console.WriteLine("Group #2");
                            stud1_g2.Output();
                            stud1_g2.Study();
                            stud1_g2.Programming();
                            stud1_g2.PlayFootball();
                            Console.WriteLine();
                            stud2_g2.Output();
                            stud2_g2.Study();
                            stud2_g2.Programming();
                            stud2_g2.PlayFootball();
                            Console.WriteLine();
                            stud3_g2.Output();
                            stud3_g2.Study();
                            stud3_g2.Programming();
                            stud3_g2.PlayFootball();
                            Console.WriteLine();
                            stud4_g2.Output();
                            stud4_g2.Study();
                            stud4_g2.Programming();
                            stud4_g2.PlayFootball();
                        }
                        else if (fr_gr + third_gr == 4)
                        {
                            Console.WriteLine("Group #1");
                            stud1_g1.Output();
                            stud1_g1.Study();
                            stud1_g1.Programming();
                            stud1_g1.PlayFootball();
                            Console.WriteLine();
                            stud2_g1.Output();
                            stud2_g1.Study();
                            stud2_g1.Programming();
                            stud2_g1.PlayFootball();
                            Console.WriteLine();
                            stud3_g1.Output();
                            stud3_g1.Study();
                            stud3_g1.Programming();
                            stud3_g1.PlayFootball();
                            Console.WriteLine();
                            stud4_g1.Output();
                            stud4_g1.Study();
                            stud4_g1.Programming();
                            stud4_g1.PlayFootball();
                            Console.WriteLine("Group #3");
                            stud1_g3.Output();
                            stud1_g3.Study();
                            stud1_g3.Programming();
                            stud1_g3.PlayFootball();
                            Console.WriteLine();
                            stud2_g3.Output();
                            stud2_g3.Study();
                            stud2_g3.Programming();
                            stud2_g3.PlayFootball();
                            Console.WriteLine();
                            stud3_g3.Output();
                            stud3_g3.Study();
                            stud3_g3.Programming();
                            stud3_g3.PlayFootball();
                            Console.WriteLine();
                            stud4_g3.Output();
                            stud4_g3.Study();
                            stud4_g3.Programming();
                            stud4_g3.PlayFootball();
                        }
                        else if (sec_gr + third_gr == 5)
                        {
                            Console.WriteLine("Group #2");
                            stud1_g2.Output();
                            stud1_g2.Study();
                            stud1_g2.Programming();
                            stud1_g2.PlayFootball();
                            Console.WriteLine();
                            stud2_g2.Output();
                            stud2_g2.Study();
                            stud2_g2.Programming();
                            stud2_g2.PlayFootball();
                            Console.WriteLine();
                            stud3_g2.Output();
                            stud3_g2.Study();
                            stud3_g2.Programming();
                            stud3_g2.PlayFootball();
                            Console.WriteLine();
                            stud4_g2.Output();
                            stud4_g2.Study();
                            stud4_g2.Programming();
                            stud4_g2.PlayFootball();
                            Console.WriteLine("Group #3");
                            stud1_g3.Output();
                            stud1_g3.Study();
                            stud1_g3.Programming();
                            stud1_g3.PlayFootball();
                            Console.WriteLine();
                            stud2_g3.Output();
                            stud2_g3.Study();
                            stud2_g3.Programming();
                            stud2_g3.PlayFootball();
                            Console.WriteLine();
                            stud3_g3.Output();
                            stud3_g3.Study();
                            stud3_g3.Programming();
                            stud3_g3.PlayFootball();
                            Console.WriteLine();
                            stud4_g3.Output();
                            stud4_g3.Study();
                            stud4_g3.Programming();
                            stud4_g3.PlayFootball();
                        }
                        else
                            Console.WriteLine("Such group doesn't exist!");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Group #1");
                        stud1_g1.Output();
                        stud1_g1.Study();
                        stud1_g1.Programming();
                        stud1_g1.PlayFootball();
                        Console.WriteLine();
                        stud2_g1.Output();
                        stud2_g1.Study();
                        stud2_g1.Programming();
                        stud2_g1.PlayFootball();
                        Console.WriteLine();
                        stud3_g1.Output();
                        stud3_g1.Study();
                        stud3_g1.Programming();
                        stud3_g1.PlayFootball();
                        Console.WriteLine();
                        stud4_g1.Output();
                        stud4_g1.Study();
                        stud4_g1.Programming();
                        stud4_g1.PlayFootball();
                        Console.WriteLine("Group #2");
                        stud1_g2.Output();
                        stud1_g2.Study();
                        stud1_g2.Programming();
                        stud1_g2.PlayFootball();
                        Console.WriteLine();
                        stud2_g2.Output();
                        stud2_g2.Study();
                        stud2_g2.Programming();
                        stud2_g2.PlayFootball();
                        Console.WriteLine();
                        stud3_g2.Output();
                        stud3_g2.Study();
                        stud3_g2.Programming();
                        stud3_g2.PlayFootball();
                        Console.WriteLine();
                        stud4_g2.Output();
                        stud4_g2.Study();
                        stud4_g2.Programming();
                        stud4_g2.PlayFootball();
                        Console.WriteLine("Group #3");
                        stud1_g3.Output();
                        stud1_g3.Study();
                        stud1_g3.Programming();
                        stud1_g3.PlayFootball();
                        Console.WriteLine();
                        stud2_g3.Output();
                        stud2_g3.Study();
                        stud2_g3.Programming();
                        stud2_g3.PlayFootball();
                        Console.WriteLine();
                        stud3_g3.Output();
                        stud3_g3.Study();
                        stud3_g3.Programming();
                        stud3_g3.PlayFootball();
                        Console.WriteLine();
                        stud4_g3.Output();
                        stud4_g3.Study();
                        stud4_g3.Programming();
                        stud4_g3.PlayFootball();
                    }
                    break;
            }

        }
    }
    class Student
    {
        string name;
        string form;
        int mark;

        public string Name { get { return name; } set { name = value; } }
        public string Form { get { return form; } set { form = value; } }
        public int Mark { get { return mark; } set { mark = value; } }

        public void Output()
        {
            Console.WriteLine($"Student : {Name} Form {Form} Mark {Mark}");

        }
        public Student(string name, string form, int mark)
        {
            Name = name;
            Form = form;
            Mark = mark;
        }
        public virtual void Study() { }
        public virtual void Programming() { }
        public virtual void PlayFootball() { }



    }
    class ExcelentStudent : Student
    {
        public ExcelentStudent(string name, string form, int mark)
            : base(name, form, mark)
        { }

        public override void Study()
        {
            if (Mark == 5)
                Console.WriteLine("This student is excelent in studying");

        }
        public override void Programming()
        {
            if (Mark == 5)
                Console.WriteLine("This student is excelent in programming");
        }
        public override void PlayFootball()
        {
            if (Mark == 5)
                Console.WriteLine("This student is excelent in football");
        }
    }
    class GoodStudent : Student
    {
        public GoodStudent(string name, string form, int mark)
            : base(name, form, mark)
        { }

        public override void Study()
        {
            if (Mark == 4)
                Console.WriteLine("This student is good in studying");

        }
        public override void Programming()
        {
            if (Mark == 4)
                Console.WriteLine("This student is good in programming");
        }
        public override void PlayFootball()
        {
            if (Mark == 4)
                Console.WriteLine("This student is good in football");
        }
    }
    class BadStudent : Student
    {
        public BadStudent(string name, string form, int mark)
            : base(name, form, mark)
        { }

        public override void Study()
        {
            if (Mark == 3)
                Console.WriteLine("This student is bad in studying");

        }
        public override void Programming()
        {
            if (Mark == 3)
                Console.WriteLine("This student is bad in programming");
        }
        public override void PlayFootball()
        {
            if (Mark == 3)
                Console.WriteLine("This student is bad in football");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string[] str_arr = Console.ReadLine().Split();
            int[] num_arr = new int[str_arr.Length];
            for (int i = 0; i < str_arr.Length; i++)
            {
                num_arr[i] = Convert.ToInt32(str_arr[i]);
            }
            Group group = new Group(num_arr);
            Console.ReadKey();


        }
    }
}
