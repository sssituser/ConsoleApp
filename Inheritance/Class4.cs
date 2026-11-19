using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            Customer cu1 = new Customer();
            
            cu1.cutomerId = 4539;
            cu1.customerName = "Suguna";
            cu1.customerContact = "9999999999";
            cu1.hno = "1-19";
            cu1.street = "Yadavbazar";
            cu1.villageName = "Karumur";

            Console.WriteLine($"Customer Id         : {cu1.cutomerId}");
            Console.WriteLine($"Customer Name       : {cu1.customerName}");
            Console.WriteLine($"Customer Contacct   : {cu1.customerContact}");
            Console.WriteLine($"Customer HouseNo    : {cu1.hno}");
            Console.WriteLine($"Customer Street     : {cu1.street}");
            Console.WriteLine($"Customer Village    : {cu1.villageName}");
        }
    }
}
