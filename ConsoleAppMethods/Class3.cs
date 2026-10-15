using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     *Write a program to find the factorial of  given number ?
     *num = 5  Factorial = 1*2*3*4*5>= fact = 120
     */
    internal class Class3
    {
        public static int Factorial(int num)
        {
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
        static void Main (string[] args)
        {
            int num = 5;
            int res = Factorial(num);
            Console.WriteLine($"{num} factorial is : {res}");
            num = 6;
            Console.WriteLine($"{num} factorial is : {Factorial(6)}");
            
        }
    }
}
