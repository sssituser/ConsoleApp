using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class20
    {
        static void Main (string[] args)
        {
            Console.Write("Enter  number-1 : ");
            int num1 = int.Parse(Console.ReadLine()); // num1 = 10

            Console.Write("Enter  number-2 : ");
            int num2 = int.Parse(Console.ReadLine()); // num2 = 20

            Kiran:
            Console.Write("1.Add\n2.Sub\n3.Mul\n4.Div\n5.Rem\n6.Exit\nEnter Your choice : ");
            int cho = int.Parse(Console.ReadLine());

            switch (cho)
            {
                case 1:
                    Console.WriteLine($"Sum is {num1 + num2}");
                    goto Kiran;
                case 2:
                    Console.WriteLine($"Sub is {num1 - num2}");
                    goto Kiran;
                case 3:
                    Console.WriteLine($"Mul is {num1 * num2}");
                    goto Kiran;
                case 4:
                    Console.WriteLine($"Quo is {num1 - num2}");
                    goto Kiran;
                case 5:
                    Console.WriteLine($"Rem is {num1 % num2}");
                    goto Kiran;
                case 6:
                    //Console.WriteLine("Press any key to Exit...");
                    break;
                default:
                    Console.WriteLine("Invalid choice ....");
                    goto Kiran;


            }
        }
    }
}
