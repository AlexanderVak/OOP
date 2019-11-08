using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Group
    {
        int group_num;
        public int Group_num { get { return group_num; } set { group_num = value; } }
        
    }
    class Student
    {
        string name;
        string form;
        int mark;

        public string Name { get { return name; } set { name = value; } }
        public string Form { get { return form; } set { form = value; } }
        public int Mark { get { return mark; } set { mark = value; } }

        public virtual void Output()
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
        {}

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
        }
    }
}
