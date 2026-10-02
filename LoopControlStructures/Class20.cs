using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class20
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); //num = 6
            int factor = 1;
            while (factor <= num)
            {
                if (num % factor == 0) 
                {
                    Console.WriteLine(factor);//1 2 3 6
                }
                factor++;
            }

        }
    }
}
