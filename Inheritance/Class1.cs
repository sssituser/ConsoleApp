using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            Employee emp1 = new Employee();

            emp1.EmployeeId = 456;
            emp1.EmlpoyeeName = "kiran";
            emp1.EmployeSalary = 50000;
            emp1.DeptId = 11;
            emp1.DeptName = "HR";
            emp1.DeptLoc = "KPHB";
            emp1.DeptHead = "Ramesh";

            Console.WriteLine($"Employee ID         : {emp1.EmployeeId}");
            Console.WriteLine($"Employee Name       : {emp1.EmlpoyeeName}");
            Console.WriteLine($"Employee Saary      : {emp1.EmployeSalary}");
            Console.WriteLine($"Department ID       : {emp1.DeptId}");
            Console.WriteLine($"Department Name     : {emp1.DeptName}");
            Console.WriteLine($"Department Head     : {emp1.DeptHead}");
            Console.WriteLine($"Department Location : {emp1.DeptLoc}");

        }
    }
}
