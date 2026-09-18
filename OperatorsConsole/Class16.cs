using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class16
    {
        static void Main (string[] args)
        {
            int x = 20;
            Console.WriteLine($"x = {++x}"); // x = 21
            Console.WriteLine($"x = {x}"); // x = 21
        }
    }
}
