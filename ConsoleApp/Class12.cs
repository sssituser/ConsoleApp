using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            string name = "kiran";
            int age = 23;
            string eduction = "B.Tech";
            double per = 7.8;
            string collegeName = "MGIT";
            string address = "HYD";

            Console.WriteLine($"{name}  {age}  {eduction}   {per}  {collegeName}  {address}");
            Console.WriteLine($"{name}\t{age}\t{eduction}\t{per}\t{collegeName}\t{address}");
            Console.WriteLine($"{name}\n{age}\n{eduction}\n{per}\n{collegeName}\n{address}");
            Console.WriteLine($"Name : {name}\nAge : {age}\nEduction : {eduction}\nCGPA : {per}\nCollege Name : {collegeName}\nAddresss : {address}");


        }
    }
}
