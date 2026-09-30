using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class13
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int max = num % 10;

            while (num > 0)
            {
                int digit = num % 10; 
                if (digit > max)
                {
                    max = digit; 
                }
                Console.WriteLine(digit); 
                num = num / 10; 
            }
            Console.WriteLine($"Max Digit In the Above number is : {max}");

        }
    }
}
