using System;

namespace CSharp.Fundamentals.SOLID
{
    class SingleResponsibility
    {
        public interface ILogger
        {
            void Info(string info);
            void Debug(string info);
            void Error(string message, Exception ex);
        }

        /// <summary>
        /// Logger Class - should be responsible in Logging
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.SOLID.SingleResponsibility.ILogger" />
        public class Logger : ILogger
        {
            public Logger()
            {
                // here we need to write the Code for initialization 
                // that is Creating the Log file with necesssary details
            }
            public void Info(string info)
            {
                // here we need to write the Code for info information into the ErrorLog text file
            }
            public void Debug(string info)
            {
                // here we need to write the Code for Debug information into the ErrorLog text file
            }
            public void Error(string message, Exception ex)
            {
                // here we need to write the Code for Error information into the ErrorLog text file
            }
        }

        /// <summary>
        /// Mail Sender Class - Should be responsbile in Sending Email
        /// </summary>
        public class MailSender
        {
            public string EMailFrom { get; set; }
            public string EMailTo { get; set; }
            public string EMailSubject { get; set; }
            public string EMailBody { get; set; }
            public void SendEmail()
            {
                // Here we need to write the Code for sending the mail
            }
        }

        /// <summary>
        /// Invoice Class - Has Only Responsibility to Add and Delete Invoice - concerates only on Invoice related activities
        /// </summary>
        public class Invoice
        {
            public long InvAmount { get; set; }
            public DateTime InvDate { get; set; }
            private ILogger fileLogger;
            private MailSender emailSender;
            public Invoice()
            {
                fileLogger = new Logger(); // Delegates the Logging Activity to Logger Class
                emailSender = new MailSender(); // Delegates the Sending Email Activities to Mail Sender Class
            }
            public void AddInvoice()
            {
                try
                {
                    fileLogger.Info("Add method Start");
                    // Here we need to write the Code for adding invoice
                    // Once the Invoice has been added, then send the  mail
                    emailSender.EMailFrom = "emailfrom@xyz.com";
                    emailSender.EMailTo = "emailto@xyz.com";
                    emailSender.EMailSubject = "Single Responsibility Princile";
                    emailSender.EMailBody = "A class should have only one reason to change";
                    emailSender.SendEmail();
                }
                catch (Exception ex)
                {
                    fileLogger.Error("Error Occurred while Generating Invoice", ex);
                }
            }
            public void DeleteInvoice()
            {
                try
                {
                    //Here we need to write the Code for Deleting the already generated invoice
                    fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
                }
                catch (Exception ex)
                {
                    fileLogger.Error("Error Occurred while Deleting Invoice", ex);
                }
            }
        }
    }
}
