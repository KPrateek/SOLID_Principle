using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    //class DIP_Violation
    //{
    //    class EventLogWriter
    //    {
    //        public void Write(string message)
    //        {
    //            Console.WriteLine(message + " Wriiten in EventLog");
    //        }
    //    }


    //    class AppPoolWatcher
    //    {
    //        // Handle to EventLog writer to write to the logs
    //        private EventLogWriter eventLogWriter = null;
    //        private EmailSender emailSender = null;
    //        private SMSSender smsSender = null;

    //        // This function will be called when the app pool has problem
    //        public void Notify(string message)
    //        {
    //            if (eventLogWriter == null)
    //            {
    //                eventLogWriter = new EventLogWriter();
    //            }
    //            eventLogWriter.Write(message);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        AppPoolWatcher appPoolWatcher = new AppPoolWatcher();
    //        appPoolWatcher.Notify("Some Log");
    //    }

    //    class EmailSender
    //    {
    //        public void Write(string message)
    //        {
    //            Console.WriteLine(message + " Sent to Email");
    //        }
    //    }
    //    class SMSSender
    //    {
    //        public void Write(string message)
    //        {
    //            Console.WriteLine(message + " Sent SMS");
    //        }
    //    }
    //}
}
