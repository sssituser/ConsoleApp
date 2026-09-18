using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class5
    {
        static void Main (string[] args)
        {
            double d1 = 4.5;
            double d2 = 2.3;
            Console.WriteLine($"d1 = {d1}\td2 = {d2}");
            Console.WriteLine($"Sum : {d1+d2}  Sub : {d1-d2}  Mul : {d1*d2}  Div : {d1/d2}  Rem : {d1%d2}");
        }
    }
}
