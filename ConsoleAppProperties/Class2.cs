using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProperties
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Console.WriteLine("=================p1 Object=========");
            Product p1 = new Product();
            p1.ProductId = 111;
            p1.ProductName= "Test";
            p1.ProductPrice = 1234;

            Console.WriteLine($"Product Id : {p1.ProductId}");
            Console.WriteLine($"Product Name : {p1.ProductName}");
            Console.WriteLine($"Product Price : {p1.ProductPrice}");
        }
    }
}
