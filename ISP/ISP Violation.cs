using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Violation
{
    public class Item
    {
        private string Document1;
        private string Document2;
        private string Document3;
    }

    interface IMachine
    {
        bool print(List<Item> item);
        bool staple(List<Item> item);
        bool fax(List<Item> item);
        bool scan(List<Item> item);
        bool photoCopy(List<Item> item);
    }
    // Code implementing the IMachine interface. 

    class Machine : IMachine
    {
        public Machine()
        {
        }

        public bool print(List<Item> item)
        {
            // Print the items.
            Console.WriteLine("Items printed " + item.Count());
            return true;
        }

        public bool staple(List<Item> item)
        {
            // Staple the items.
            Console.WriteLine("Items stapled " + item.Count());
            return true;
        }

        public bool fax(List<Item> item)
        {
            // Fax the items.
            Console.WriteLine("Items Faxed " + item.Count());
            return true;
        }

        public bool scan(List<Item> item)
        {
            // Scan the items.
            Console.WriteLine("Items Scanned " + item.Count());
            return true;
        }

        public bool photoCopy(List<Item> item)
        {
            // Xerox the items.
            Console.WriteLine("Items Photo copied " + item.Count());
            return true;
        }
    }  

    //class ISP_Violation
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Item> documentItem = new List<Item>();
    //        Item documentItem1 = new Item();
    //        documentItem.Add(documentItem1);
    //        Machine machine = new Machine();
    //        machine.fax(documentItem);
    //    }
    //}
}
