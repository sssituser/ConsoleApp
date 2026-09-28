using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    internal class Class18
    {
     
            static void Main (string[] args)
            {
                Console.Write("Enter  number-1 : ");
                int num1 = int.Parse(Console.ReadLine()); // num1 = 10

                Console.Write("Enter  number-2 : ");
                int num2 = int.Parse(Console.ReadLine()); // num2 = 20

                Console.Write("Add\nSub\nMul\nDiv\nRem\nEnter Your choice : ");
               
                string cho = Console.ReadLine();
                cho = cho.ToLower();
                switch (cho)
                {
                    case "add":
                        Console.WriteLine($"Sum is {num1 + num2}");
                        break;
                    case "sub":
                        Console.WriteLine($"Sub is {num1 - num2}");
                        break;
                    case "mul":
                        Console.WriteLine($"Mul is {num1 * num2}");
                        break;
                    case "div":
                        Console.WriteLine($"Quo is {num1 - num2}");
                        break;
                    case "rem":
                        Console.WriteLine($"Rem is {num1 % num2}");
                        break;
                    default:
                        Console.WriteLine("Invalid choice ....");
                        break;
                }
            }
        }

    }
