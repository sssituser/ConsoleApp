using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class29
    { 
            // 5 4 3 2 1
        static void Main (string[] args)
        {
            for(int start = 5; start >= 1; start -= 1) // start=5 5>=1-T 4;4>=1 ;  2 0>=1-F
            { 
                Console.WriteLine(start);//5 4 3 2 1
            }
        }
    }
}
