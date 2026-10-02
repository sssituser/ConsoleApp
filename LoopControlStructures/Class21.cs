using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class21
    {
        static void Main (string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int factor = 1;
            int count = 0;
            while (factor <= num)
            {
                if(num%factor == 0)
                {
                    Console.WriteLine(factor);
                    count++;
                }
                factor++;
               
                
            }
            Console.WriteLine($"{num} has {count} factors");
        }
    }
}
