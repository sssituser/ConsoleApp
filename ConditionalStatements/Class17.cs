using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class17
    {
        static void Main (string[] args)
        {
            Console.Write("Enter  number-1 : ");
            int num1 = int.Parse(Console.ReadLine()); // num1 = 10

            Console.Write("Enter  number-2 : ");
            int num2 = int.Parse(Console.ReadLine()); // num2 = 20

            Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Rem\nEnter Your choice : ");
            int cho = int.Parse(Console.ReadLine());

            switch (cho)
            {
                case 1:
                    Console.WriteLine($"Sum is {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Sub is {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Mul is {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"Quo is {num1 - num2}");
                    break;
                case 5:
                    Console.WriteLine($"Rem is {num1 % num2}");
                    break;
                default:
                    Console.WriteLine("Invalid choice ....");
                    break;
            }
        }
    }

}
