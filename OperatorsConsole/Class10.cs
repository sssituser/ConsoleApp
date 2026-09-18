using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsole
{
    internal class Class10
    {
        static void Main (string[] args)
        {
            int sub1 = 40;
            int sub2 = 50;
            int sub3 = 60;
            int sub4 = 70;
            int sub5 = 80;
            int sub6 = 30;
            Console.WriteLine( (sub1 < 35 || sub2 < 35 || sub3 < 35 || sub4 < 35 || sub5 < 35 || sub6 < 35));
            Console.WriteLine(! (sub1 < 35 || sub2 < 35 || sub3 < 35 || sub4 < 35 || sub5 < 35 || sub6 < 35));
        }
    }
}
