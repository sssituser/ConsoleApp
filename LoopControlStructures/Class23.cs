using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class23
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int fctr = int.Parse(Console.ReadLine());
            int count = 0;
            while (fctr <= num)
            {
                if(num%fctr== 0)
                {
                    Console.WriteLine(fctr);
                    count++;
                }
                fctr++;
            }

            if (count == 2)
            {
                Console.WriteLine($"{num} is  a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime number");
            }
        }
    }
}
