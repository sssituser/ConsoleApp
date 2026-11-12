using System;

namespace ConsoleAppConstructors
{
    internal class Employee
    {
        static Employee ()
        {
            Console.WriteLine("Hi Iam static Constructor");
        }
        public Employee ()
        {
            Console.WriteLine("Hi Iam Instance(non static) Constructor");
        }

    }
}
