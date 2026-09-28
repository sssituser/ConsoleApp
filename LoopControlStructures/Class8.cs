using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class8
    {
        static void Main (string[] args)
        {
            int num = 23;

            int sum = num % 10 + num / 10;
            Console.WriteLine($"Sum of two digits of a given number : {sum}");
        }
    }
}
