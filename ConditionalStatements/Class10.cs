using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class10
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num < 10)
                {
                    Console.WriteLine($"{num} is +ve number and single digit");
                }
                else
                {
                    Console.WriteLine($"{num} is +ve number but not a single digit");
                }
            }
            else
            {
                Console.WriteLine($"Given number may be  0 Or -Ve");
            }
        }
    }
}
