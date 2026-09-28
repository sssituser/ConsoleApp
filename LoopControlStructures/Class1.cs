using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    // Write a program to generate number from 1 to given number 
    // 1 3 5 7 9 11 13 15
    internal class Class1
    {
        static void Main (string[] args)
        {
            int start = 1;
            int end = 15;
            
            while(start <= end)  // 17<=15-F 3<=15 5<=15 7<=15 9<=15 11<=15 13<=15 15<=15
            {
                Console.WriteLine(start); //1 3 5 7 9 11 13 15
                start = start + 2; //start = 17
            }
            
        }
    }
}
