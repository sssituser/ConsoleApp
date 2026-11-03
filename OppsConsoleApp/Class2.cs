using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            Employee emp1 = new Employee() { employeeId=111,employeeName ="abc",employeeSalary=8000};

            Employee emp2 = new Employee()
            {
                employeeId = 112,
                employeeName = "def",
                employeeSalary = 90000
            };

            Employee emp3 = new Employee();
            emp3.employeeId = 113;
            emp3.employeeName = "pqr";
            emp3.employeeSalary = 70000;


            Console.WriteLine($"EmployeeID : {emp1.employeeId}\tEmployeeName : {emp1.employeeName}\tEmployee Salary : {emp1.employeeSalary}");
            Console.WriteLine($"EmployeeID : {emp2.employeeId}\tEmployeeName : {emp2.employeeName}\tEmployee Salary : {emp2.employeeSalary}");
            Console.WriteLine($"EmployeeID : {emp3.employeeId}\tEmployeeName : {emp3.employeeName}\tEmployee Salary : {emp3.employeeSalary}");



        }
    }
}
