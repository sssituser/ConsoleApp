using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());  // num1  = 8

            Console.Write("Enter num2 : ");
            int num2= int.Parse(Console.ReadLine());  // num2 = 3

            Console.WriteLine(num1+num2); //11
            Console.WriteLine(num1-num2);  //5
            Console.WriteLine(num1*num2); //24
            Console.WriteLine(num1/num2); //
            Console.WriteLine(num1%num2);

        }
    }
}
