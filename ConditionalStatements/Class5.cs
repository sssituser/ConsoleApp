using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class5
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even number");
            }

            if(num%2 != 0)
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
