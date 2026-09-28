using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Program
    {
        static void Main (string[] args)
        {
            int start = 1;
            int end = 10;
          
            while(start <= end) // 1<=5-T 3<=5 5<=5 7<=5F
            {
                Console.WriteLine($"{start}"); //1 3 5
                start = start+1; // start = 7
            }
        }
    }
}
