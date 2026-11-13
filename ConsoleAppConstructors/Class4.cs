using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            Console.WriteLine("========Customer-1 Object======");
            Customer cu1=new Customer();
            Console.WriteLine(cu1.GetCustomer());

            Console.WriteLine("========Customer-2 Object======");
            Customer cu2 = new Customer(112,"Vijay","9898989898");
            Console.WriteLine(cu2.GetCustomer());


            Console.WriteLine("========Customer-3 Object======");
            Customer cu3 = new Customer(113, "Vijay", "7979797979");
            Console.WriteLine(cu3.GetCustomer());


            Console.WriteLine("========Customer-4 Object======");
            Customer cu4 = new Customer(cu2);
            Console.WriteLine(cu4.GetCustomer());


        }
    }
}
