using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Class5
    {
        static void Main (string[] args)
        {
            Console.WriteLine("==============p1 Object===============");
            Product p1 = new Product();
            p1.SetProduct(111, "abc", 500);
            p1.GetProduct();

            Console.WriteLine("==============p2 Object===============");
            Product p2 = new Product();
            p2.SetProduct(112, "def", 400);
            p2.GetProduct();

        }
    }
}
