using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class31
    {
        static void Main (string[] args)
        {
            // num = 5
            int num = 5;
            for (int start = 1; start <= num; start++)
            {
                Console.WriteLine("=============");// 1 2

                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{start} x {j} = {start*j}");
                }
            }
        }
    }
}
