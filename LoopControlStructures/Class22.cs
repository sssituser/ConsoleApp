using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class22
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num  = int.Parse(Console.ReadLine());
            int fctr = 1;
            int sum = 0;
            while (fctr <= num)
            {
                if (num % fctr == 0)
                {
                    Console.WriteLine(fctr);
                    sum = sum + fctr;
                }
                fctr++;
            }

            Console.WriteLine($"Sum of the Factors of {num} is {sum}");
        }
    }
}
