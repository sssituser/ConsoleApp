using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    // Factorial 5:   
   //5! =  1*2*3*4*5 => 120
    internal class Class5
    {
        static void Main (string[] args)
        {
            int start = 1;
            int end = 4;
            int fact = 1;
            do // 1<=5 2<=5 3<=5 4<=5 5<=5 6<=5-F
            {

                fact = fact * start;// fact = 120
                start = start + 1; // start = 6
            } while (start <= end);
            Console.WriteLine($"{end}! is {fact}");
            
        }
    }
}
