using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProperties
{
    internal class Student
    {
    
      private  int studentId;
      private  string studentName;
      private  int studentMarks;

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        public int StudentMarks
        {
            get { return studentMarks; }
            set { studentMarks = value; }
        }

    }
}
