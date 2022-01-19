using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Fundamentals.SOLID
{
    class OpenClosedPrinciple
    {
        static void Main(string[] args)
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.ReadKey();
        }

        /// <summary>
        /// Parent Class
        /// </summary>
        public class Invoice
        {
            public virtual double GetInvoiceDiscount(double amount)
            {
                return amount - 10;
            }
        }

        /// <summary>
        /// Derived Class - Allow us to implement the OCP which should be inherited from the original base class
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.SOLID.OpenClosedPrinciple.Invoice" />
        public class FinalInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 50;
            }
        }

        /// <summary>
        /// Derived Class
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.SOLID.OpenClosedPrinciple.Invoice" />
        public class ProposedInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 40;
            }
        }

        /// <summary>
        /// Derived Class
        /// </summary>
        /// <seealso cref="CSharp.Fundamentals.SOLID.OpenClosedPrinciple.Invoice" />
        public class RecurringInvoice : Invoice
        {
            public override double GetInvoiceDiscount(double amount)
            {
                return base.GetInvoiceDiscount(amount) - 30;
            }
        }
    }
}
