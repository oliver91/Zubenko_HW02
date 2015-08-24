using System;
using System.Collections.Generic;
using System.IO;

namespace Abstraction_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> handlers = new List<AbstractHandler>();
            handlers.Add(new XMLHandler());
            handlers.Add(new DOCHandler());
            handlers.Add(new TXTHandler());
            foreach (AbstractHandler h in handlers)
            {
                h.Change();
                h.Create();
                h.Open();
                h.Save();
            }
            Console.ReadKey();
        }
    }

    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    internal class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Invoke method Open() for XML");
        }

        public override void Create()
        {
            Console.WriteLine("Invoke method Create() for XML");
        }

        public override void Change()
        {
            Console.WriteLine("Invoke method Change() for XML");
        }

        public override void Save()
        {
            Console.WriteLine("Invoke method Save() for XML");
        }
    }

    internal class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Invoke method Open() for TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Invoke method Create() for TXT");
        }

        public override void Change()
        {
            Console.WriteLine("Invoke method Change() for TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Invoke method Save() for TXT");
        }
    }

    internal class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Invoke method Open() for DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Invoke method Create() for DOC");
        }

        public override void Change()
        {
            Console.WriteLine("Invoke method Change() for DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Invoke method Save() for DOC");
        }
    }

}
