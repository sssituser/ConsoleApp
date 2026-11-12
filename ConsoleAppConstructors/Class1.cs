using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppConstructors
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            Console.WriteLine("============Student-1======================");
            Student s1 = new Student();
            s1.SetStudent(111, "abc", 600);
            s1.GetStudent();

            Console.WriteLine("============Student-2======================");
            Student s2 = new Student();
            s2.SetStudent(112, "def", 660);          
            s2.GetStudent();
        }
    }
}
