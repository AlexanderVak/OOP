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



            int length = Group_arr.Length;

            GoodStudent g_stud1_gr1 = new GoodStudent("Petro", "10-A", 4);
            ExcelentStudent e_stud2_gr1 = new ExcelentStudent("Olena", "10-A", 5);
            BadStudent b_stud3_gr1 = new BadStudent("Dima", "10-A", 3);
            GoodStudent g_stud4_gr1 = new GoodStudent("Kate", "10-A", 4);

            ExcelentStudent e_stud1_gr2 = new ExcelentStudent("Vika", "10 - B", 5);
            BadStudent b_stud2_gr2 = new BadStudent("Oleg", "10-B", 3);
            BadStudent b_stud3_gr2 = new BadStudent("Bohdan", "10-B", 3);
            GoodStudent g_stud4_gr2 = new GoodStudent("Kostya", "10-B", 4);


            ExcelentStudent e_stud1_gr3 = new ExcelentStudent("Ihor", "10-C", 5);
            ExcelentStudent e_stud2_gr3 = new ExcelentStudent("Ivan", "10-C", 5);
            GoodStudent g_stud3_gr3 = new GoodStudent("Max", "10-C", 4);
            GoodStudent g_stud4_gr3 = new GoodStudent("Ira", "10-C", 4);

            switch (length)
            {
                case 1:
                    {
                        if (Group_arr[0] == 1)
                        {
                            Console.WriteLine("Group #1\n");
                            g_stud1_gr1.Output();

                            Console.WriteLine();
                            e_stud2_gr1.Output();

                            Console.WriteLine();
                            b_stud3_gr1.Output();

                            Console.WriteLine();
                            g_stud4_gr1.Output();

                        }
                        else if (Group_arr[0] == 2)
                        {

                            Console.WriteLine("Group #2\n");
                            e_stud1_gr2.Output();

                            Console.WriteLine();
                            b_stud2_gr2.Output();

                            Console.WriteLine();
                            b_stud3_gr2.Output();

                            Console.WriteLine();
                            g_stud4_gr2.Output();
                        }
                        else if (Group_arr[0] == 3)
                        {
                            Console.WriteLine("Group #3\n");
                            e_stud1_gr3.Output();

                            Console.WriteLine();
                            e_stud2_gr3.Output();

                            Console.WriteLine();
                            g_stud3_gr3.Output();

                            Console.WriteLine();
                            g_stud4_gr3.Output();
                        }
                        else
                            Console.WriteLine("Such group doesn't exist!");
                    }
                    break;
                case 2:
                    {

                        if (group_arr[0] + group_arr[1] == 3)
                        {
                            Console.WriteLine("Group #1\n");
                            g_stud1_gr1.Output();

                            Console.WriteLine();
                            e_stud2_gr1.Output();

                            Console.WriteLine();
                            b_stud3_gr1.Output();

                            Console.WriteLine();
                            g_stud4_gr1.Output();

                            Console.WriteLine("Group #2\n");
                            e_stud1_gr2.Output();

                            Console.WriteLine();
                            b_stud2_gr2.Output();

                            Console.WriteLine();
                            b_stud3_gr2.Output();

                            Console.WriteLine();
                            g_stud4_gr2.Output();
                        }
                        if (group_arr[0] + group_arr[1] == 4)
                        {
                            Console.WriteLine("Group #1\n");
                            g_stud1_gr1.Output();

                            Console.WriteLine();
                            e_stud2_gr1.Output();

                            Console.WriteLine();
                            b_stud3_gr1.Output();

                            Console.WriteLine();
                            g_stud4_gr1.Output();

                            Console.WriteLine("Group #3\n");
                            e_stud1_gr3.Output();

                            Console.WriteLine();
                            e_stud2_gr3.Output();

                            Console.WriteLine();
                            g_stud3_gr3.Output();

                            Console.WriteLine();
                            g_stud4_gr3.Output();
                        }
                        if (group_arr[0] + group_arr[1] == 5)
                        {
                            Console.WriteLine("Group #2\n");
                            e_stud1_gr2.Output();

                            Console.WriteLine();
                            b_stud2_gr2.Output();

                            Console.WriteLine();
                            b_stud3_gr2.Output();

                            Console.WriteLine();
                            g_stud4_gr2.Output();

                            Console.WriteLine("Group #3\n");
                            e_stud1_gr3.Output();

                            Console.WriteLine();
                            e_stud2_gr3.Output();

                            Console.WriteLine();
                            g_stud3_gr3.Output();

                            Console.WriteLine();
                            g_stud4_gr3.Output();
                        }
                        else
                            Console.WriteLine("Such group doesn't exist!");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Group #1\n");
                        g_stud1_gr1.Output();

                        Console.WriteLine();
                        e_stud2_gr1.Output();

                        Console.WriteLine();
                        b_stud3_gr1.Output();

                        Console.WriteLine();
                        g_stud4_gr1.Output();

                        Console.WriteLine("Group #2\n");
                        e_stud1_gr2.Output();

                        Console.WriteLine();
                        b_stud2_gr2.Output();

                        Console.WriteLine();
                        b_stud3_gr2.Output();

                        Console.WriteLine();
                        g_stud4_gr2.Output();

                        Console.WriteLine("Group #3\n");
                        e_stud1_gr3.Output();

                        Console.WriteLine();
                        e_stud2_gr3.Output();

                        Console.WriteLine();
                        g_stud3_gr3.Output();

                        Console.WriteLine();
                        g_stud4_gr3.Output();

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
            Study();
            Programming();
            PlayFootball();
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
            Console.Write("Please, enter numbers of group : ");
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
