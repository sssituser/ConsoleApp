using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{

    //  public non static fileds
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StudentMarks { get; set; }

        public Address StudentAddres { get; set; }

        public override string ToString ()
        {
            return $"Student ID\t: {StudentId}\nStudent Name\t: {StudentName}\nMarks\t\t: {StudentMarks}\nAddress\t-----------------{StudentAddres}";
        }
    }
}
