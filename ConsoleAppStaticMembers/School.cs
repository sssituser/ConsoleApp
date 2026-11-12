using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticMembers
{
    internal class School
    {
        public int StudentId;
        public string StudentName;
        public static string SchoolName;

        public void ShowStudentInfo ()
        {
            Console.WriteLine($"Student ID : {StudentId}\tStudent Name : {StudentName}\tSchool Name :{SchoolName}");
        }
    }
}
