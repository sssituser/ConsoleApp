using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class15
    {
        static void Main (string[] args)
        {
            int num = 123;
            int sum = 0;
            int mul = 1;
            while (num > 0) {
                int digit = num % 10;
                sum = sum + digit;
                mul = mul*digit;
                num = num / 10;
            }
           
            if (sum == mul)
            {
                Console.WriteLine("Given number is Special number");
            }
            else
            {
                Console.WriteLine("Given number is not a Special number");
            }
        }
    }
}
