using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class9
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); 
            while (num > 0)
            {
                int digit = num % 10; 
                Console.WriteLine(digit);
                num = num / 10;
            }

        }
    }
}
