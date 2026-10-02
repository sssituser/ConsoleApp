using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{

    //5 => 1+2+3+4+5 =>15
    //10 => 1+2+3+4+..+10=>55
    internal class Class4
    {
        static void Main (string[] args)
        {
            int start = 1;
            int end = 5;
            int sum = 0;
            do // 1<=5-T 2<=5 3<=5 4<=5 5<=5 6<=5-F
            {

                sum = sum + start; // sum = 15
                start = start + 1; // start = 6
            } while (start <= end);
            Console.WriteLine($"Sum {end } nums is : {sum}");
        }
    }
}
