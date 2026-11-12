using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProperties
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Employee emp = new Employee();
            emp.EmployeeId = 111;
            emp.EmployeeName = "abc";
            emp.EmployeeSal = 70000;

            Console.WriteLine($"Employee ID : {emp.EmployeeId}");
            Console.WriteLine($"Employee Name : {emp.EmployeeName}");
            Console.WriteLine($"Employee Salary : {emp.EmployeeSal}");

            
        }
    }
}
