using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class15
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Subject - 1 Marks : ");
            int sub1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject - 2 Marks : ");
            int sub2 = int.Parse(Console.ReadLine());


            Console.Write("Enter Subject - 3 Marks : ");
            int sub3 = int.Parse(Console.ReadLine());
            int per = (sub1 + sub2 + sub3) / 3;
            if(sub1<35 || sub2<35 || sub3 < 35)
            {
                Console.WriteLine("Student Failed");
            }
            else if(per>=70)
            {
                Console.WriteLine("Student Passed in Distinction");
            }else if (per >= 60)
            {
                Console.WriteLine("Student Passed in First Division");
            }else if (per >= 50)
            {
                Console.WriteLine("Student Passed in Second Division");
            }
            else
            {
                Console.WriteLine("Student Passed in Third Division");
            }

        }
    }
}
