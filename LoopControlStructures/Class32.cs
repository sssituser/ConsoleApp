using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class32
    {
        static void Main (string[] args)
        {
            int num = 5;
            int k = 1;
            for (int start = 1; start <= num; start++)
            { 
                
                for(int j = 1; j <= start; j++) 
                {
                    Console.Write($"{k++}\t");//1
                }
                Console.WriteLine();
            }
        }
    }
}
