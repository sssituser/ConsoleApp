using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class7
    {
        static void Main (string[] args)
        {
            int num1 = 5;
            int num2 = 2;
            Console.WriteLine(num1 > num2);       //  5 >  2      True
            Console.WriteLine(num1 >= num2);     //   5 >= 2    True
            Console.WriteLine(num1 < num2);     //    5 <  2      False
            Console.WriteLine(num1 <= num2);   //     5 <= 2    False
            Console.WriteLine(num1 == num2);  //      5 == 2    False
            Console.WriteLine(num1 != num2); //       5 != 2    True
            Console.WriteLine($"{num1 > num2}  {num1 >= num2}  {num1 < num2}  {num1 <= num2}  {num1==num2} {num1!=num2}");

            Console.WriteLine($"{num1} > {num2}  : {num1 > num2}");
            Console.WriteLine($"{num1} >= {num2} : {num1 >= num2}");
            Console.WriteLine($"{num1} < {num2}  : {num1 < num2}");
            Console.WriteLine($"{num1} <= {num2} : {num1 <= num2}");
            Console.WriteLine($"{num1} == {num2} : {num1 == num2}");
            Console.WriteLine($"{num1} != {num2} : {num1 != num2}");
            Console.WriteLine($"{num1} > {num2}  : {num1 > num2}    {num1} >= {num2} : {num1 >= num2}     {num1} < {num2} : {num1 < num2}");

        }
    }
}
