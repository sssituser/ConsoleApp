using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Emply
    {
        int empId;
        string empName;
        int empSal;

        public Emply ()  // Default Constrcutor
        {
            Console.WriteLine("==========================");
            empId = 111;
            empName = "abc";
            empSal = 45000;
            Console.WriteLine("Hi Iam Default Constructor");
        }
        public Emply (int empId,string empName,int empSal)  // constructor with Paramters
        {
            Console.WriteLine("==========================");
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
            Console.WriteLine("Hi Iam Constructor With Parameters");
        }

        public void GetEmply ()
        {
            Console.WriteLine($"Employee ID     : {empId}");
            Console.WriteLine($"Employee Name   : {empName}");
            Console.WriteLine($"Employee Salary : {empSal}");
        }
    }
}
