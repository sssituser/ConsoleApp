using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class3
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 0
            if (num > 0)
            {
                Console.WriteLine($"{num} is +ve");
                Console.WriteLine("Hi number check is done");
            }
        }
    }
}
