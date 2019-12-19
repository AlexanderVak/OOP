using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Laba3
{
    abstract class AbstractHandler
    {
        public string Name { get; set; }
        public AbstractHandler(string name)
        {
            Name = name;
        }

        public abstract void Info();
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public XMLHandler(string name)
            : base(name)
        {
            Info();
        }
        public override void Info()
        {
            Create();
            Open();
            Change();
            Save();
        }
        public override void Open()
        {
            Console.WriteLine($"XML file \"{Name}\" is opened");
        }
        public override void Create()
        {
            Console.WriteLine($"New XML file \"{Name}\" is created");
        }
        public override void Change()
        {
            Console.WriteLine($"XML file \"{Name }\" is changed");
        }
        public override void Save()
        {
            Console.WriteLine($"XML file \"{Name}\" is saved");
        }


    }
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string name)
          : base(name)
        {
            Info();
        }
        public override void Info()
        {
            Create();
            Open();
            Change();
            Save();
        }
        public override void Open()
        {
            Console.WriteLine($"TXT file \"{Name}\" is opened");
        }
        public override void Create()
        {
            Console.WriteLine($"New TXT file \"{Name}\" is created");
        }
        public override void Change()
        {
            Console.WriteLine($"TXT file \"{Name }\" is changed");
        }
        public override void Save()
        {
            Console.WriteLine($"TXT file \"{Name}\" is saved");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string name)
          : base(name)
        {
            Info();
        }
        public override void Info()
        {
            Create();
            Open();
            Change();
            Save();
        }
        public override void Open()
        {
            Console.WriteLine($"DOC file \"{Name}\" is opened");
        }
        public override void Create()
        {
            Console.WriteLine($"New DOC file \"{Name}\" is created");
        }
        public override void Change()
        {
            Console.WriteLine($"DOC file \"{Name }\" is changed");
        }
        public override void Save()
        {
            Console.WriteLine($"DOC file \"{Name}\" is saved");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter name and format of your file.\nFor example \"example.txt\"");
            string format = Console.ReadLine().Trim();
            Regex xmlRegex = new Regex(@"\w*[.]xml$");
            Regex txtRegex = new Regex(@"\w*[.]txt$");
            Regex docRegex = new Regex(@"\w*[.]doc$");
            MatchCollection xmlMatches = xmlRegex.Matches(format);
            MatchCollection txtMatches = txtRegex.Matches(format);
            MatchCollection docMatches = docRegex.Matches(format);
            if (xmlMatches.Count > 0)
            {
                AbstractHandler xml = new XMLHandler(format);
            }
            else if (txtMatches.Count > 0)
            {
                AbstractHandler txt = new TXTHandler(format);
            }
            else if (docMatches.Count > 0)
            {
                AbstractHandler doc = new DOCHandler(format);
            }
            else
                Console.WriteLine("Incorrect input data!");
            Console.ReadKey();
        }
    }

}


