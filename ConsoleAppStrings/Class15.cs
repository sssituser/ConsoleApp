using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class15
    {
        static void Main (string[] args)
        {
            string s = null;

            Console.WriteLine(string.IsNullOrEmpty(s));
            s = "abc";
            Console.WriteLine(string.IsNullOrEmpty(s));
            


        }
    }
}
