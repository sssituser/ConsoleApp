using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class1
    {
        static void Main (string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum : {num1+num2}\nSub : {num1-num2}\nMul : {num1*num2}\nQuo : {num1/num2}\nRem : {num1%num2}");
        }
    }
}
