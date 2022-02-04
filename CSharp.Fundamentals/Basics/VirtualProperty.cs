using System;

namespace CSharp.Fundamentals.Basics
{
    public class VirtualProperty
    {
        public static void Main()
        {
            BankCustomer BankCustomerObject = new BankCustomer();
            BankCustomerObject.FirstName = "David";
            BankCustomerObject.LastName = "Boon";
            Console.WriteLine("Customer Full Name is : " + BankCustomerObject.FullName);
        }
    }

    class Customer
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        // FullName is virtual
        public virtual string FullName // enable derived class to override the property behavior.
        {
            get
            {
                return _lastName + ", " + _firstName;
            }
        }
    }
    class BankCustomer : Customer
    {
        // Overriding the FullName virtual property derived from customer class
        public override string FullName
        {
            get
            {
                return "Mr. " + FirstName + " " + LastName;
            }
        }
    }
}
