using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class6
    {
        static void Main (string[] args)
        {
            int start = 1;
            int end = 10;
            int num = 6;
            while (start <= end)
            {
                Console.WriteLine($"{num} x {start} = {start*num} ");
                start = start + 1;
            }
        }
    }
}
