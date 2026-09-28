using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class16
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());  // num = 3

            if (num == 0)
            {
                Console.WriteLine("ZERO");
            }
            else if (num == 1)
            {
                Console.WriteLine("ONE");
            }
            else if (num == 2)
            {
                Console.WriteLine("TWO");
            }
            else
            {
                Console.WriteLine("Entered Value is Other Than 0,1 2");
            }
        }
    }
}
