using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class14
    {
        static void Main (string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());// num1 = 5
            
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());  // num2 = 5
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is a maximum number");
            }else if (num2 > num1)
            {
                Console.WriteLine($"{num2} is a maximum number");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are equal...");
            }
        }
    }
}
