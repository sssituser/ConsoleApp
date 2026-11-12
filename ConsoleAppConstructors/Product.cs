using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Product
    {
        int proId;
        string proName;
        int proPrice;

        public void SetProduct (int proId,string proName,int proPrice)
        {
            this.proId = proId;
            this.proName = proName;
            this.proPrice = proPrice;
        }
        public void GetProduct ()
        {
            Console.WriteLine($"Product ID : {proId}");
            Console.WriteLine($"Product Name : {proName}");
            Console.WriteLine($"Product Price : {proPrice}");
        }

    }
}
