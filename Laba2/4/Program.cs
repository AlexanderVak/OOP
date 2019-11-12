using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class DocumentWorker
    {
        public void Output()
        {
            OpenDocument();
            EditDocument();
            SaveDocument();
        }
        public virtual void OpenDocument()
        {
            Console.WriteLine("\nDocument is open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing is avalible in Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving is avalible in Pro version");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("Document was edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document was saved in old format," +
                " saving in new format is avalible in Expert version");
        }
    }
    class ExpertDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }
        public override void EditDocument()
        {
            Console.WriteLine("Document was edited");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Document was saved in new format");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the key (XXX-XXX-XXX or XXX-XXX-XXX-XXX )");
            string key = Console.ReadLine();
            const string proKey = "123-456-789";
            const string expKey = "ABC-DEF-GHI-jKL";
            switch (key)
            {
                case proKey:
                    {
                        ProDocumentWorker proDoc = new ProDocumentWorker();
                        DocumentWorker doc = proDoc;
                        doc.Output();
                    }
                    break;
                case expKey:
                    {
                        ExpertDocumentWorker expDoc = new ExpertDocumentWorker();
                        DocumentWorker doc = expDoc;
                        doc.Output();
                    }
                    break;
                default:
                    {
                        DocumentWorker doc = new DocumentWorker();
                        doc.Output();
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}
