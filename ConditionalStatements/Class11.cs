using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class11
    {
        static void Main (string[] args)
        {
            Console.Write("Enter Age : ");
            int age = int.Parse(Console.ReadLine());// age = 23
            if (age > 17)
            {
                if (age < 21)
                {
                    Console.WriteLine("You Can Vote");
                }
                else
                {
                    Console.WriteLine("You Can Vote and You can Marry");
                }
            }
            else
            {
                Console.WriteLine("You Can't Vote");
            }
        }
    }
}
