using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class11
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");

            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num != 0) 
            {
                int digit = num % 10; // digit = 3 digit = 2 digit = 1
               // Console.WriteLine(digit); // 3 2
                sum = sum + digit; // sum = 6
                num = num / 10; // num = 12 num = 1/10 num = 0
            }
            Console.WriteLine($"Sum of the digits of the given number :{sum}");
        }
    }
}
