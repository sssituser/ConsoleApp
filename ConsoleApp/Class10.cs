using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            // Initialization
            string name = "kiran";
            int age = 23;
            string edu = "B.Tech";
            double per = 6.8;
            string contact = "99999999999";
            string address = "Hyd";

            Console.WriteLine($"{name} {age} {edu} {per} {contact} {address}");
            Console.WriteLine($"{name}\t{age}\t{edu}\t{per}\t{contact}\t{address}");
            Console.WriteLine($"{name}\n{age}\n{edu}\n{per}\n{contact}\n{address}");
            Console.WriteLine($"Name : {name}\nAge : {age}\nQualification : {edu}\nPercentage : {per}\nContact : {contact}\nAddress : {address}");
        }
    }
}
