using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Item
    {
        private string Document1;
        private string Document2;
        private string Document3;
    }

    interface IPrinter
    {
        bool Print(List<Item> items);
    }


    interface IStapler
    {
        bool Staple(List<Item> Items);
    }

    interface IFaxer
    {
        bool Fax(List<Item> Items);
    }

    interface IScanner
    {
        bool Scan(List<Item> Items);
    }

    interface IPhotoCopier
    {
        bool PhotoCopy(List<Item> Items);
    }

    class Printer : IPrinter
    {
        public bool Print(List<Item> items)
        {
            foreach (var item in items)
                Console.WriteLine("Printing");
            return true;
        }
        //Other definitions...
    }

   

    class Stapler : IStapler
    {
        public bool Staple(List<Item> items)
        {
            foreach (var item in items)
                Console.WriteLine("stapling");
            return true;
        }

        //Other definitions...
    }


    class Faxer : IFaxer
    {
        public bool Fax(List<Item> items)
        {
            foreach (var item in items)
                Console.WriteLine("Faxing");
             return true;
       }

        //Other definitions...
    }

   
    class Scanner : IScanner
    {
        public bool Scan(List<Item> items)
        {
            foreach (var item in items)
                Console.WriteLine("Scanning");
             return true;
       }

        //Other definitions...
    }

    

    class PhotoCopier : IPhotoCopier
    {
        public bool PhotoCopy(List<Item> items)
        {
            foreach (var item in items)
                Console.WriteLine("Photo copying");
            return true;
        }

        //Other definitions...
    }

    interface IMachine : IPrinter, IPhotoCopier, IStapler
    {
        bool Print(List<Item> item);
        bool Staple(List<Item> item);
        bool PhotoCopy(List<Item> item);
    }

    internal class Machine : IMachine
    {
        public bool Print(List<Item> item)
        {
            return true;
        }

        public bool Staple(List<Item> item)
        {
            return true;
        }
        public bool PhotoCopy(List<Item> item)
        {
            return true;
        }
    }

    class ISP
    {
        static void Main(string[] args)
        {
            List<Item> documentItem = new List<Item>();
            Item documentItem1 = new Item();
            documentItem.Add(documentItem1);
           
        }
    }
}
