using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            Student s1 = new Student();
            s1.StudentId = 1;
            s1.StudentName = "Test";
            s1.StudentMarks = 500;
            s1.StudentAddres = new Address() { Area="KPHB",Street="RoadNo1",Pincode="500082",District="RRDist",State="Telangana" };

            Console.WriteLine(s1);
        }
    }
}
