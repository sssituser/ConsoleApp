using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    public interface ILogic
    {
        void Save ();
    }
    class BusinessLogic : ILogic
    {
        public void Save ()
        {
            Console.WriteLine("Student Saved");
        }
    }
    class Student
    {

        ILogic il;
      public Student (ILogic xl)
        {
            this.il = xl;
        }
        public void AddStudent ()
        {
            il.Save();
        }
    }
    internal class Class15
    {
        static void Main (string[] args)
        {
            BusinessLogic bl = new BusinessLogic ();
            Student s = new Student(bl);
            s.AddStudent();
        }
    }
}
