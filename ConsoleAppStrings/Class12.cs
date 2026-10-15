using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            string s1 = "a"; //ASCII - 97  97>98
            string s2 = "a"; //ASCII - 98
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s1)); // 98<97
        }
    }
}
