using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    // 5 to 1
    // 5 4 3 2 1
    //20 , 18,16..2
    internal class Class3
    {
        static void Main (string[] args)
        {
            int start = 10;
            int end = 1;

            while(start >= end)
            {
                Console.WriteLine(start);
                start = start - 1;
            }

        }
    }
}
