using System;

namespace OppsConsoleApp
{
    internal class Product
    {
         int product_id;
         string product_name;
         int product_price;
        public void SetProduct (int id,string name,int price/*local variables*/)
        {
            product_id = id;
            product_name = name;
            product_price = price;
        }
        public void GetProduct ()
        {
            Console.WriteLine($"Prouct Id : {product_id}");
            Console.WriteLine($"Prouct Name : {product_name}");
            Console.WriteLine($"Prouct Price : {product_price}");
        }
       
    }
}
