using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Deparatment dept = new Deparatment();
            dept.DeptId = 11;
            dept.DeptName = "HR";
            dept.DeptHead = "Ramesh";
            dept.DeptLoc = "KPHB";
            Console.WriteLine($"Department ID       : {dept.DeptId}");
            Console.WriteLine($"Department Name     : {dept.DeptName}");
            Console.WriteLine($"Department Head     : {dept.DeptHead}");
            Console.WriteLine($"Department Location : {dept.DeptLoc}");
        }
    }
}
