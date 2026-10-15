using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMethods
{
    /*
     * Write a program to find the sum of N numbers for the given number ?
     * Example : num = 5   Res : 1+2+3+4+5 => 15
     * Write a
     */
    internal class Class2
    {
        public static int SumOfNums(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main (string[] args)
        {
            int num = 5;
            int res = SumOfNums(num);
            Console.WriteLine($"Sum of {num} numbers is :{res}");
            num = 10;
            Console.WriteLine($"Sum of {num} numbers is : {SumOfNums(num)}");
        }
    }
}
