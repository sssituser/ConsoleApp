using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class9
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine()); // age = 18
            if (age < 18)
            {
                Console.WriteLine("Your Can't Vote");
            }
            else
            {
                Console.WriteLine("You Can Vote");
            }
        }
    }
}
