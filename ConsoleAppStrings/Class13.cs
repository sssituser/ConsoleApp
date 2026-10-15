using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class13
    {
        static void Main (string[] args)
        {
            string s1 = "abc"; // b Ascii - 98  c Ascii - 99 98<99   
            string s2 = "abb";
            Console.WriteLine(s1.CompareTo(s2));

        }
    }
}
