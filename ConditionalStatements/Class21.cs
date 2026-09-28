using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    /*
     * goto is jumping , goto statement can move the compiler in the program during execution as per the
     * requirement.
     */
    internal class Class21
    {
        static void Main (string[] args)
        {
            start:
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); //5
            if (num <= 0) 
            {
                goto start;
            }else if (num % 2 == 0) 
            {
                Console.WriteLine("Given number even");
                goto step;
            }
            else
            {
                Console.WriteLine("Odd Number");
                goto exit;
            }
            step:
            num += 2;
            Console.WriteLine($"num : {num}");
            goto start;
            exit:
            Console.WriteLine("Exiting the appliation");
        }
    }
}   
