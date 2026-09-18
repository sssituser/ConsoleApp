using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class12
    {
        static void Main (string[] args)
        {
            bool con = false;

            Console.WriteLine(con ? "Hi":"bye");
            Console.WriteLine(con ? 10 : 20);
            Console.WriteLine(con ? 6.7 : 5.8);
        }
    }
}
