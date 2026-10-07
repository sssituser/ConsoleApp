using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControlStructures
{
    internal class Class35
    {
        static void Main (string[] args)
        {
            string s = "kiran";
            Console.WriteLine($"{s}");
            Console.WriteLine("After Using Forech loop");
            foreach(char ch in s)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
