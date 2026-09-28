using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class19
    {
        static void Main (string[] args)
        {
            Console.Write("Enter  number-1 : ");
            int num1 = int.Parse(Console.ReadLine()); // num1 = 10

            Console.Write("Enter  number-2 : ");
            int num2 = int.Parse(Console.ReadLine()); // num2 = 20

            Console.Write("+\n-\n*\n div \n % \nEnter Your choice : ");
            char cho = char.Parse(Console.ReadLine());
            
            switch (cho)
            {
                case '+':
                    Console.WriteLine($"Sum is {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Sub is {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Mul is {num1 * num2}");
                    break;
                case '/':
                    Console.WriteLine($"Quo is {num1 / num2}");
                    break;
                case '%':
                    Console.WriteLine($"Rem is {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice ....");
                    break;
            }
        }
    }
}
