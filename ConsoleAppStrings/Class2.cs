using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class2
    {
        static void Main (string[] args)
        {
            string s = "WELCOME";
            Console.WriteLine(s); // WELCOME
            string x = s.ToLower();
            Console.WriteLine(x);
            Console.WriteLine(s); // WELCOME
        }
    }
}
