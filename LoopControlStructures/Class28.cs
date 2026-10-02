using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class28
    {
        static void Main (string[] args)
        {
            // 2 4 6 8 ...20
            // 3 6 9  12 15... 30
            for(int start = 2; start <= 20; start += 2)
            {
                Console.WriteLine(start);
            }

            for(int start = 3; start <= 30; start += 3)
            {
                Console.WriteLine(start);
            }
        }
    }
}
