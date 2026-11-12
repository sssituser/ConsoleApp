using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticMembers
{
    // static class can hold only static members
    // we can't object for static class
    internal static class Test
    {
         static int num1 = 10;
         static int num2 = 20;
        public static void Sum ()
        {
            Console.WriteLine($"Sum is {num1+num2}");
        }
       
    }
}
