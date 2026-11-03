using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            Demo1 p = new Demo1();
            p.fullName = "Kiran";
            p.age = 22;
            p.gender = "Male";

            Demo1 q = new Demo1();

            q.fullName = "Samntha";
            q.gender = "Female";
            q.age = 35;

            Demo1 r = new Demo1() { fullName="Raj",age=35,gender ="Male"};


            Demo1 l = new Demo1()
            {
                fullName = "Rani",
                age = 33,
                gender = "Female"
            };

            Console.WriteLine($"Name : {p.fullName}\tAge : {p.age}\tGender : {p.gender}"); ;
            Console.WriteLine($"Name : {q.fullName}\tAge : {q.age}\tGender : {q.gender}"); ;
            Console.WriteLine($"Name : {r.fullName}\tAge : {r.age}\tGender : {r.gender}"); ;
            Console.WriteLine($"Name : {l.fullName}\tAge : {l.age}\tGender : {r.gender}"); ;





        }
    }
}
