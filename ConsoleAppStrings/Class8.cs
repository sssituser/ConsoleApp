using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings
{
    internal class Class8
    {
        static void Main (string[] args)
        {
            string dob = "19-Oct-2002";
            string[] res = dob.Split('-');
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);
        }
    }
}
