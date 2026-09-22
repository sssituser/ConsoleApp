using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class7
    {
        static void Main (string[] args)
        {
            /*
             * Write a program to check given number even or odd
             */

            Console.Write("Enter a num : ");
            int num = int.Parse(Console.ReadLine()); // num = 7
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} Is An Even Number");
            }
            else
            {
                Console.WriteLine($"{num} Is An Odd Number ");
            }
        }
    }
}
