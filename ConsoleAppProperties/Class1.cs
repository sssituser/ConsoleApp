using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProperties
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            Student s1 =new Student();
            Console.WriteLine("====================s1 Object==============");
            s1.StudentId = 111;
            s1.StudentName = "abc";
            s1.StudentMarks = 600;

            Console.WriteLine($"Student ID : {s1.StudentId}");
            Console.WriteLine($"Student Name : {s1.StudentName}");
            Console.WriteLine($"Student Marks : {s1.StudentMarks}");
        }
    }
}
