using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class18
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a base number  : ");
            int bnum = int.Parse(Console.ReadLine()); 

            Console.Write("Enter a power number : "); 
            int pnum = int.Parse(Console.ReadLine());

            int start = 1;
            int mul = 1;
            while (start <= pnum) 
            {
               
                mul = mul * bnum;
                start ++;
            }
            Console.WriteLine($"{bnum} to the power of {pnum} is : {mul}");

        }
    }
}
