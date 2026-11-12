using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Student
    {
        int studentId;
        string studentName;
        int studentMarks;
        public void SetStudent (int id,string name,int marks/*local variables*/)
        {
            studentId = id;
            studentName = name;
            studentMarks = marks;
        }
        public void GetStudent ()
        {
            Console.WriteLine($"Student Id    : {studentId}");
            Console.WriteLine($"Student Name  : {studentName}");
            Console.WriteLine($"Student Marks : {studentMarks}");
        }
    }
}
