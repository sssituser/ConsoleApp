using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class7
    {
        static void Main (string[] args)
        {
            int start = 1;
            int num = 5;
            int sum = 0;
            int fact = 1;
            while (start <= num)
            {
                Console.WriteLine(start);
                sum = sum + start;
                fact = fact * start;
                start++;
            }
            Console.WriteLine($"Sum of {num} numbers is : {sum}");
            Console.WriteLine($"{num} Factorial is : {fact}");
        }
    }
}
