using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class34
    {
        static void Main (string[] args)
        {
            int k = 65;
            int num = 5;
            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)k}\t");
                    k++;
                }
                Console.WriteLine();
            }

            for(int i = num - 1; i >= 1; i--)
            {
                for(int j= 1; j <= i; j++)
                {
                    Console.Write($"{(char)k}\t");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
