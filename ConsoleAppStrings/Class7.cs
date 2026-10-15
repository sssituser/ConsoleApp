using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class7
    {
        static void Main (string[] args)
        {
            string res = "kiran";
            Console.WriteLine(res[0]);
            Console.WriteLine(res.ElementAt(1));
            Console.WriteLine(res.ElementAt(2));
            Console.WriteLine(res.IndexOf('r'));
            Console.WriteLine(res.IndexOf('n'));

        }
    }
}
