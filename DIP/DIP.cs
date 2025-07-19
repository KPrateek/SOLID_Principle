using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    internal class DIP
    {
        public interface INofificationAction
        {
            void ActOnNotification(string message);
        }

        class EventLogWriter : INofificationAction
        {
            public void ActOnNotification(string message)
            {
                Console.WriteLine(message + " Wriiten in EventLog");

            }
        }

        class EmailSender : INofificationAction
        {
            public void ActOnNotification(string message)
            {
                Console.WriteLine(message + " Sent to Email");
            }
        }

        class SMSSender : INofificationAction
        {
            public void ActOnNotification(string message)
            {
                Console.WriteLine(message + " Sent SMS");
            }
        }

        private class AppPoolWatcher
        {
            // Handle to EventLog writer to write to the logs
            private INofificationAction action = null;

            // This function will be called when the app pool has problem. Dependency injection
            public void Notify(INofificationAction concreteAction, string message)
            {
                if (concreteAction != null)
                {
                    action = concreteAction;
                    action.ActOnNotification(message);
                }
            }
        }

        static void Main(string[] args)
        {
            AppPoolWatcher appPoolWatcher = new AppPoolWatcher();
            EventLogWriter eventLogWriterwriter = new EventLogWriter();
            EmailSender emailSender = new EmailSender();
            SMSSender smsSender = new SMSSender();


            appPoolWatcher.Notify(eventLogWriterwriter, "Some Log");
        }

    }
}
