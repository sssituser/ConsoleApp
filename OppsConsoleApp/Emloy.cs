using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Emloy
    {
        public int empId; // non static fields or Instance fields
        public string empName;
        public int empSal;

        // non static methods or instance methods
        public  void SetEmply (int eid,string ename,int esal)
        {
            Console.WriteLine("Hi Iam SetEmply Method ");
            empId = eid;
            empName = ename;
            empSal = esal;
        }
        public void GetEmply ()
        {
            Console.WriteLine("Hi Iam Get Emply Method and Iam showing the information");
            Console.WriteLine($"EmployeeID : {empId}\tEmployee Name : {empName}\tEmployee Salary : {empSal}");
        }
    }
}
