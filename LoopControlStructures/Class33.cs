using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class33
    {
        static void Main (string[] args)
        {
            int k = 65;
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)k}\t");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
//ASCII A-65