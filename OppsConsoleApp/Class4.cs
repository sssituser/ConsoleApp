using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Class4
    {
        static void Main (string[] args)
        {
            Emloy emp1 = new Emloy();
            emp1.empId = 1;
            emp1.empName = "abc";
            emp1.empSal = 50000;

            Emloy emp2 = new Emloy() { empId=2,empName="def",empSal=60000};


            Emloy emp3 = new Emloy()
            {
                empId = 3,
                empName = "pqr",
                empSal = 70000
            };

            Emloy emp4 = new Emloy();
            emp4.SetEmply(4, "lmn", 80000);

            Emloy emp5 = new Emloy();
            emp5.SetEmply(5, "stu", 80000);

            Console.WriteLine("==========emp1 object Information==========");
            Console.WriteLine($"EmpId : {emp1.empId}\tEmpName : {emp1.empName}\tEmpSal : {emp1.empSal}");

            Console.WriteLine("==========emp2 object Information==========");
            Console.WriteLine($"EmpId : {emp2.empId}\tEmpName : {emp2.empName}\tEmpSal : {emp2.empSal}");

            Console.WriteLine("==========emp3 object Information==========");
            Console.WriteLine($"EmpId : {emp3.empId}\tEmpName : {emp3.empName}\tEmpSal : {emp3.empSal}");
            
            Console.WriteLine("==========emp4 object Information==========");
            emp4.GetEmply();

            Console.WriteLine("==========emp5 object Information==========");
            emp5.GetEmply();
        }
    }
}
