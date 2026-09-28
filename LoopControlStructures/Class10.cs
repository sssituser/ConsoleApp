using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class10
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); //1234
            int count = 0;
            while (num > 0) 
            {
                int digit = num % 10; 
                count++; 
                Console.WriteLine(digit); 
                num = num / 10;

            }
            Console.WriteLine($"About number has {count} digits");
        }
    }
}
