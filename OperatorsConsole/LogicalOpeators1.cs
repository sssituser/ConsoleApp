using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class LogicalOpeators1
    {
        static void Main (string[] args)
        {
            bool con1 = true;
            bool con2 = false;

            Console.WriteLine(con1 && con2);// false
           
            con2 = true;
            Console.WriteLine(con1 && con2); // true
        }
    }
}
