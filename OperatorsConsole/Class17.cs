using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class17
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num1 = int.Parse(Console.ReadLine());
            string res = num1 % 2 == 0 ? $"{num1} is An Eeven Number" : $"{num1} is An Odd Number";
            Console.WriteLine(res);
        }
    }
}
