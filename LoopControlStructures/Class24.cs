using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class24
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int fctr = 1;
            int sum = 0;
            do
            {
                if (num % fctr == 0)
                {
                    //Console.WriteLine(fctr);
                    sum = sum + fctr;
                }
                fctr++;
            } while (fctr < num);
            if (sum == num)
            {
                Console.WriteLine($"{num} is  a Perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Perfect number");
            }
        }
    }
}
