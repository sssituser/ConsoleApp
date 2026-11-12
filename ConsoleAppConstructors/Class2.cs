using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Console.WriteLine("=============Product-1 Object======");
            Product pr1 = new Product();
            pr1.SetProduct(11, "abc", 500);
            pr1.GetProduct();

            Console.WriteLine("=============Product-1 Object======");
            Product pr2 = new Product();
            pr2.SetProduct(12, "def", 550);
            pr2.GetProduct();
        }
    }
}
