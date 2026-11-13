using System;

namespace ConsoleAppConstructors
{
    internal class Customer
    {
        int customerId;
        string customerName;
        string customerContact;

        public Customer ()
        {
            customerId = 111;
            customerName = "abc";
            customerContact = "9999999999";
            Console.WriteLine("Default Constructor Called");
        }
        public Customer (int customerId, string customerName, string customerContact)
        {
            this.customerId= customerId;
            this.customerName= customerName;
            this.customerContact= customerContact;
            Console.WriteLine("Parameterised Constructor Called");
        }
        
        public string GetCustomer ()
        {
            return $"Customer Id : {customerId}\nCustomerName : {customerName}\nCustomer Contact:{customerContact}";
        }
        public Customer (Customer customer)
        {
            customerId=customer.customerId;
            customerName=customer.customerName;
            customerContact=customer.customerContact;
            Console.WriteLine("Copy Constructor Called");

        }
        ~ Customer ()
        {
            Console.WriteLine("Destructor Called");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
