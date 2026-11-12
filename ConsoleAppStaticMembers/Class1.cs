using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticMembers
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            School.SchoolName = "xyz";

            Console.WriteLine("===========Student-1===================");
            School s1 =  new School();
            s1.StudentId = 111;
            s1.StudentName = "kiran";
            s1.ShowStudentInfo();

            Console.WriteLine("===========Student-2===================");
            School s2 = new School();
            s2.StudentId = 112;
            s2.StudentName = "raj";    
            s2.ShowStudentInfo();
            
        }
    }
}
